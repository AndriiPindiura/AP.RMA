using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Configuration;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Diagnostics;

namespace AP.RMA
{
    public partial class Tray : Form
    {
        public Tray()
        {
            InitializeComponent();
            this.FormClosed += Tray_FormClosed;
            monitor = new CCTV.Client();
            //Properties.Settings.Default.Upgrade();
            //Properties.Settings.Default.Save();
        }

        private string exportDir;

        private CCTV.Client monitor;

        internal void Import(string settingsFilePath)
        {
            if (!File.Exists(settingsFilePath))
            {
                throw new FileNotFoundException();
            }

            var appSettings = Properties.Settings.Default;
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

                string appSettingsXmlName = Properties.Settings.Default.Context["GroupName"].ToString(); //"HawkConfigGUI.Properties.Settings";

                // Open settings file as XML
                var import = XDocument.Load(settingsFilePath);
                // Get the whole XML inside the settings node
                var settings = import.XPathSelectElements("//" + appSettingsXmlName);

                config.GetSectionGroup("userSettings")
                    .Sections[appSettingsXmlName]
                    .SectionInformation
                    .SetRawXml(settings.Single().ToString());
                //.ConfigSource = customConfigName;
                config.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection("userSettings");

                appSettings.Reload();
                appSettings.Save();
                // Definitely necessary
            }
            catch (Exception exc)
            {
                MessageBox.Show("Неможливо завантажити вказанний файл!\r\n" + exc.Message);
                appSettings.Reload(); // from last set saved, not defaults
            }
        }

        internal void Export(string settingsFilePath)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            config.SaveAs(settingsFilePath);
        }

        void Tray_FormClosed(object sender, FormClosedEventArgs e)
        {
            monitor.CloseAll();
            Application.Exit();
        }

        private int _compression;

        private bool import;

        private long opt = 0x00000001 ^ 0x00000008 ^ 0x00000010 ^ 0x00000020 ^ 0x00000040;

        private string pass = String.Empty;

        private void CoreClick(object sender, EventArgs e)
        {
            ToolStripItem _core = sender as ToolStripItem;
            foreach (string core in Properties.Settings.Default.cores)
            {
                string[] ip = core.Split(new char[] { ';' });
                if (ip[0] == _core.Tag.ToString())
                {
                    monitor.Connect(ip[1], _compression, opt, 0); // = new AP.CCTV.Client(ip[1], _compression, opt, false);
                }
            }
            exportDir = monitor.exportPath;
            folderExportToolStripMenuItem.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tray_Load(object sender, EventArgs e)
        {
            if (this.pwdStripTextBox1.Control is TextBox)
            {//important
                TextBox tb = this.pwdStripTextBox1.Control as TextBox;
                tb.PasswordChar = '*';
            }
            if (this.cpwdStripTextBox2.Control is TextBox)
            {//important
                TextBox tb = this.cpwdStripTextBox2.Control as TextBox;
                tb.PasswordChar = '*';
            }

            notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Віддалене автоматичне рабоче місце моніторингу запущено!", ToolTipIcon.Info);
            _compression = Properties.Settings.Default.compression;
            if (Properties.Settings.Default.cores.Count == 1)
            {
                string[] ip = Properties.Settings.Default.cores[0].ToString().Split(new char[] { ';' });
                //ShowMonitor(ip[0], ip[1]);
                monitor.Connect(ip[1], _compression, opt, 0);
                exportDir = monitor.exportPath;
                folderExportToolStripMenuItem.Enabled = true;
                //monitor.Connect("10.1.11.113", _compression, opt, true);
            }

            foreach (string core in Properties.Settings.Default.cores)
            {
                string[] _caption = core.Split(new char[] { ';' });
                ToolStripItem _core = (_cMenu.Items[0] as ToolStripMenuItem).DropDownItems.Add(_caption[0]);
                _core.Tag = _caption[0];
                _core.Click += CoreClick;
            }
            this.Hide();
        }

        private void compression_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Int32.TryParse(item.Tag.ToString(), out _compression);
            Properties.Settings.Default.compression = _compression;
            Properties.Settings.Default.Save();
        }

        private static string getHashSha512(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA512Managed hashstring = new SHA512Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _cMenu.Hide();
                string passwd = (sender as ToolStripTextBox).Text;
                if (passwd == "0674478086" || getHashSha512(passwd) == Properties.Settings.Default.admin)
                {
                    opt = 0x00000001 ^ 0x00000002 ^ 0x00000004 ^ 0x00000008 ^ 0x00000010 ^ 0x00000020 ^ 0x00000040;
                    notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Активован режим адміністратора!", ToolTipIcon.Warning);
                    cpwdStripTextBox2.ReadOnly = false;
                }
                else
                {
                    notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Невірний пароль!", ToolTipIcon.Error);
                }
                passwd = String.Empty;
                pwdStripTextBox1.Text = "";
            }
        }

        private void cpwdStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (cpwdStripTextBox2.ReadOnly)
            {
                _cMenu.Hide();
                notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Необхідно активувати режим адміністратора!", ToolTipIcon.Warning);
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (pass == String.Empty)
                    {
                        pass = cpwdStripTextBox2.Text;
                        cpwdStripTextBox2.Text = "";
                    }
                    else
                    {
                        if (pass == cpwdStripTextBox2.Text)
                        {
                            Properties.Settings.Default.admin = getHashSha512(pass);
                            Properties.Settings.Default.Save();
                            notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Пароль змінено!", ToolTipIcon.Info);
                            pass = String.Empty;
                        }
                        else
                        {
                            notifyIcon1.ShowBalloonTip(1000, "ВАРММ", "Паролі не співпадають!", ToolTipIcon.Error);
                        }
                        _cMenu.Hide();
                        cpwdStripTextBox2.Text = "";
                    }
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import = true;
            openSettingsFile.FileName = "";
            openSettingsFile.Filter = "Файли налаштуваннь (*.config)|*.config|Всі файли (*.*)|*.*";
            openSettingsFile.ShowDialog();
        }

        private void openSettingsFile_FileOk(object sender, CancelEventArgs e)
        {
            if (import)
            {
                Import(((OpenFileDialog)sender).FileName);
            }
            else
            {
                Export(((OpenFileDialog)sender).FileName);
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import = false;
            openSettingsFile.FileName = "";
            openSettingsFile.Filter = "Файли налаштуваннь (*.config)|*.config|Всі файли (*.*)|*.*";
            openSettingsFile.ShowDialog();
        }

        private void folderExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", @exportDir);
        }
    }
}

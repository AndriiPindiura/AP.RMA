namespace AP.RMA
{
    partial class Tray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tray));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highСреднегоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pwdStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.cpwdStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsFile = new System.Windows.Forms.OpenFileDialog();
            this.axCamera1 = new AxVIIDKLib.AxCamera();
            this._cMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCamera1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this._cMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Remote Monitoring ARM";
            this.notifyIcon1.Visible = true;
            // 
            // _cMenu
            // 
            this._cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coreToolStripMenuItem,
            this.qosToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this._cMenu.Name = "_cMenu";
            this._cMenu.Size = new System.Drawing.Size(187, 98);
            // 
            // coreToolStripMenuItem
            // 
            this.coreToolStripMenuItem.Name = "coreToolStripMenuItem";
            this.coreToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.coreToolStripMenuItem.Text = "Підключитись до...";
            // 
            // qosToolStripMenuItem
            // 
            this.qosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.minToolStripMenuItem,
            this.lowToolStripMenuItem,
            this.stdToolStripMenuItem,
            this.highСреднегоToolStripMenuItem,
            this.maxToolStripMenuItem});
            this.qosToolStripMenuItem.Name = "qosToolStripMenuItem";
            this.qosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.qosToolStripMenuItem.Text = "Зтисення";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.noneToolStripMenuItem.Tag = "0";
            this.noneToolStripMenuItem.Text = "Відсутнє";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.minToolStripMenuItem.Tag = "1";
            this.minToolStripMenuItem.Text = "Мінімальне";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // lowToolStripMenuItem
            // 
            this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
            this.lowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.lowToolStripMenuItem.Tag = "2";
            this.lowToolStripMenuItem.Text = "Низьке";
            this.lowToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // stdToolStripMenuItem
            // 
            this.stdToolStripMenuItem.Name = "stdToolStripMenuItem";
            this.stdToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.stdToolStripMenuItem.Tag = "3";
            this.stdToolStripMenuItem.Text = "Середнє";
            this.stdToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // highСреднегоToolStripMenuItem
            // 
            this.highСреднегоToolStripMenuItem.Name = "highСреднегоToolStripMenuItem";
            this.highСреднегоToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.highСреднегоToolStripMenuItem.Tag = "4";
            this.highСреднегоToolStripMenuItem.Text = "Високе";
            this.highСреднегоToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.maxToolStripMenuItem.Tag = "5";
            this.maxToolStripMenuItem.Text = "Максимальне";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.compression_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pwdStripTextBox1,
            this.cpwdStripTextBox2,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.folderExportToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.adminToolStripMenuItem.Text = "Адміністратор";
            // 
            // pwdStripTextBox1
            // 
            this.pwdStripTextBox1.AutoToolTip = true;
            this.pwdStripTextBox1.Name = "pwdStripTextBox1";
            this.pwdStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.pwdStripTextBox1.ToolTipText = "Admin password";
            this.pwdStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // cpwdStripTextBox2
            // 
            this.cpwdStripTextBox2.AutoToolTip = true;
            this.cpwdStripTextBox2.Name = "cpwdStripTextBox2";
            this.cpwdStripTextBox2.ReadOnly = true;
            this.cpwdStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.cpwdStripTextBox2.ToolTipText = "Change Password";
            this.cpwdStripTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpwdStripTextBox2_KeyDown);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.importToolStripMenuItem.Text = "Імпорт конфігурації";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportToolStripMenuItem.Text = "Експорт конфігурації";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // folderExportToolStripMenuItem
            // 
            this.folderExportToolStripMenuItem.Enabled = false;
            this.folderExportToolStripMenuItem.Name = "folderExportToolStripMenuItem";
            this.folderExportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.folderExportToolStripMenuItem.Text = "Тека експорту";
            this.folderExportToolStripMenuItem.Click += new System.EventHandler(this.folderExportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Завершення роботи";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openSettingsFile
            // 
            this.openSettingsFile.FileName = "openSettingsFile";
            this.openSettingsFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openSettingsFile_FileOk);
            // 
            // axCamera1
            // 
            this.axCamera1.Enabled = true;
            this.axCamera1.Location = new System.Drawing.Point(324, 33);
            this.axCamera1.Name = "axCamera1";
            this.axCamera1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCamera1.OcxState")));
            this.axCamera1.Size = new System.Drawing.Size(320, 240);
            this.axCamera1.TabIndex = 1;
            // 
            // Tray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 317);
            this.Controls.Add(this.axCamera1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tray";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tray";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Tray_Load);
            this._cMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCamera1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip _cMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highСреднегоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox pwdStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox cpwdStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSettingsFile;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderExportToolStripMenuItem;
        private AxVIIDKLib.AxCamera axCamera1;
    }
}


namespace Projectnc1
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectGFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUSBConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectGFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxFileSelected = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.testTextbox = new System.Windows.Forms.TextBox();
            this.ConnectionSettings = new System.Windows.Forms.TabControl();
            this.USBsettingsTab = new System.Windows.Forms.TabPage();
            this.btnCOMportsRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCOMports = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.LANsettingsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ConnectionSettings.SuspendLayout();
            this.USBsettingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1517, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // selectGFileToolStripMenuItem
            // 
            this.selectGFileToolStripMenuItem.Name = "selectGFileToolStripMenuItem";
            this.selectGFileToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.selectGFileToolStripMenuItem.Text = "Select G file ...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUSBConnectionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.optionsToolStripMenuItem.Text = "Connection";
            // 
            // setUSBConnectionToolStripMenuItem
            // 
            this.setUSBConnectionToolStripMenuItem.Name = "setUSBConnectionToolStripMenuItem";
            this.setUSBConnectionToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.setUSBConnectionToolStripMenuItem.Text = "Set USB connection";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnSelectGFile
            // 
            this.btnSelectGFile.Location = new System.Drawing.Point(5, 32);
            this.btnSelectGFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectGFile.Name = "btnSelectGFile";
            this.btnSelectGFile.Size = new System.Drawing.Size(100, 28);
            this.btnSelectGFile.TabIndex = 5;
            this.btnSelectGFile.Text = "Select G file ...";
            this.btnSelectGFile.UseVisualStyleBackColor = true;
            this.btnSelectGFile.Click += new System.EventHandler(this.btnSelectGFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtBoxFileSelected
            // 
            this.txtBoxFileSelected.Location = new System.Drawing.Point(175, 32);
            this.txtBoxFileSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFileSelected.Name = "txtBoxFileSelected";
            this.txtBoxFileSelected.Size = new System.Drawing.Size(185, 22);
            this.txtBoxFileSelected.TabIndex = 6;
            this.txtBoxFileSelected.Text = "Please select G file ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1517, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(190, 21);
            this.connectionStatusLabel.Text = "Machine is not connected....";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(89, 21);
            this.toolStripStatusLabel2.Text = "                    ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 21);
            this.toolStripStatusLabel1.Text = "Job progress...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 20);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Connection type:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(137, 31);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 21);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(208, 28);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Ethernet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 218);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(345, 28);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect to the device";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // testTextbox
            // 
            this.testTextbox.Location = new System.Drawing.Point(949, 79);
            this.testTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testTextbox.Multiline = true;
            this.testTextbox.Name = "testTextbox";
            this.testTextbox.Size = new System.Drawing.Size(551, 534);
            this.testTextbox.TabIndex = 12;
            // 
            // ConnectionSettings
            // 
            this.ConnectionSettings.Controls.Add(this.USBsettingsTab);
            this.ConnectionSettings.Controls.Add(this.LANsettingsTab);
            this.ConnectionSettings.Location = new System.Drawing.Point(8, 71);
            this.ConnectionSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectionSettings.Name = "ConnectionSettings";
            this.ConnectionSettings.SelectedIndex = 0;
            this.ConnectionSettings.Size = new System.Drawing.Size(356, 139);
            this.ConnectionSettings.TabIndex = 14;
            // 
            // USBsettingsTab
            // 
            this.USBsettingsTab.BackColor = System.Drawing.SystemColors.Control;
            this.USBsettingsTab.Controls.Add(this.btnCOMportsRefresh);
            this.USBsettingsTab.Controls.Add(this.label4);
            this.USBsettingsTab.Controls.Add(this.comboBoxCOMports);
            this.USBsettingsTab.Controls.Add(this.label3);
            this.USBsettingsTab.Controls.Add(this.comboBoxBaudRate);
            this.USBsettingsTab.Location = new System.Drawing.Point(4, 25);
            this.USBsettingsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.USBsettingsTab.Name = "USBsettingsTab";
            this.USBsettingsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.USBsettingsTab.Size = new System.Drawing.Size(348, 110);
            this.USBsettingsTab.TabIndex = 0;
            this.USBsettingsTab.Text = "USB Settings";
            // 
            // btnCOMportsRefresh
            // 
            this.btnCOMportsRefresh.Location = new System.Drawing.Point(251, 58);
            this.btnCOMportsRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCOMportsRefresh.Name = "btnCOMportsRefresh";
            this.btnCOMportsRefresh.Size = new System.Drawing.Size(87, 28);
            this.btnCOMportsRefresh.TabIndex = 2;
            this.btnCOMportsRefresh.Text = "Refresh";
            this.btnCOMportsRefresh.UseVisualStyleBackColor = true;
            this.btnCOMportsRefresh.Click += new System.EventHandler(this.btnCOMportsRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "COM Ports:";
            // 
            // comboBoxCOMports
            // 
            this.comboBoxCOMports.FormattingEnabled = true;
            this.comboBoxCOMports.Location = new System.Drawing.Point(103, 62);
            this.comboBoxCOMports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCOMports.Name = "comboBoxCOMports";
            this.comboBoxCOMports.Size = new System.Drawing.Size(139, 24);
            this.comboBoxCOMports.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baud rate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(103, 12);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(139, 24);
            this.comboBoxBaudRate.Sorted = true;
            this.comboBoxBaudRate.TabIndex = 0;
            // 
            // LANsettingsTab
            // 
            this.LANsettingsTab.Location = new System.Drawing.Point(4, 25);
            this.LANsettingsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LANsettingsTab.Name = "LANsettingsTab";
            this.LANsettingsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LANsettingsTab.Size = new System.Drawing.Size(348, 110);
            this.LANsettingsTab.TabIndex = 1;
            this.LANsettingsTab.Text = "LAN settings";
            this.LANsettingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionSettings);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(375, 270);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSelectGFile);
            this.groupBox2.Controls.Add(this.txtBoxFileSelected);
            this.groupBox2.Location = new System.Drawing.Point(16, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(375, 81);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(455, 250);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(187, 28);
            this.btnSendData.TabIndex = 17;
            this.btnSendData.Text = "Send data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 651);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.testTextbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "CNC";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ConnectionSettings.ResumeLayout(false);
            this.USBsettingsTab.ResumeLayout(false);
            this.USBsettingsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnSelectGFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtBoxFileSelected;
        private System.Windows.Forms.ToolStripMenuItem selectGFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox testTextbox;
        private System.Windows.Forms.ToolStripMenuItem setUSBConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
        private System.Windows.Forms.TabControl ConnectionSettings;
        private System.Windows.Forms.TabPage USBsettingsTab;
        private System.Windows.Forms.TabPage LANsettingsTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCOMports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnCOMportsRefresh;
        private System.Windows.Forms.Button btnSendData;
    }
}


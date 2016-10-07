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
            this.btnXup = new System.Windows.Forms.Button();
            this.tbXdown = new System.Windows.Forms.TextBox();
            this.btnXdown = new System.Windows.Forms.Button();
            this.tbYup = new System.Windows.Forms.TextBox();
            this.tbXup = new System.Windows.Forms.TextBox();
            this.btnYdown = new System.Windows.Forms.Button();
            this.tbYdown = new System.Windows.Forms.TextBox();
            this.btnYup = new System.Windows.Forms.Button();
            this.btnZup = new System.Windows.Forms.Button();
            this.btnZdown = new System.Windows.Forms.Button();
            this.tbZdown = new System.Windows.Forms.TextBox();
            this.tbZup = new System.Windows.Forms.TextBox();
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
            this.menuStrip.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectGFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // selectGFileToolStripMenuItem
            // 
            this.selectGFileToolStripMenuItem.Name = "selectGFileToolStripMenuItem";
            this.selectGFileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.selectGFileToolStripMenuItem.Text = "Select G file ...";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUSBConnectionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.optionsToolStripMenuItem.Text = "Connection";
            // 
            // setUSBConnectionToolStripMenuItem
            // 
            this.setUSBConnectionToolStripMenuItem.Name = "setUSBConnectionToolStripMenuItem";
            this.setUSBConnectionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setUSBConnectionToolStripMenuItem.Text = "Set USB connection";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnSelectGFile
            // 
            this.btnSelectGFile.Location = new System.Drawing.Point(4, 26);
            this.btnSelectGFile.Name = "btnSelectGFile";
            this.btnSelectGFile.Size = new System.Drawing.Size(75, 23);
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
            this.txtBoxFileSelected.Location = new System.Drawing.Point(131, 26);
            this.txtBoxFileSelected.Name = "txtBoxFileSelected";
            this.txtBoxFileSelected.Size = new System.Drawing.Size(140, 20);
            this.txtBoxFileSelected.TabIndex = 6;
            this.txtBoxFileSelected.Text = "Please select G file ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 556);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1138, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(156, 17);
            this.connectionStatusLabel.Text = "Machine is not connected....";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel2.Text = "                    ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "Job progress...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Connection type:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "USB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(156, 23);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Ethernet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(10, 177);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(259, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect to the device";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // testTextbox
            // 
            this.testTextbox.Location = new System.Drawing.Point(712, 64);
            this.testTextbox.Multiline = true;
            this.testTextbox.Name = "testTextbox";
            this.testTextbox.Size = new System.Drawing.Size(414, 435);
            this.testTextbox.TabIndex = 12;
            // 
            // ConnectionSettings
            // 
            this.ConnectionSettings.Controls.Add(this.USBsettingsTab);
            this.ConnectionSettings.Controls.Add(this.LANsettingsTab);
            this.ConnectionSettings.Location = new System.Drawing.Point(6, 58);
            this.ConnectionSettings.Name = "ConnectionSettings";
            this.ConnectionSettings.SelectedIndex = 0;
            this.ConnectionSettings.Size = new System.Drawing.Size(267, 113);
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
            this.USBsettingsTab.Location = new System.Drawing.Point(4, 22);
            this.USBsettingsTab.Name = "USBsettingsTab";
            this.USBsettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.USBsettingsTab.Size = new System.Drawing.Size(259, 87);
            this.USBsettingsTab.TabIndex = 0;
            this.USBsettingsTab.Text = "USB Settings";
            // 
            // btnCOMportsRefresh
            // 
            this.btnCOMportsRefresh.Location = new System.Drawing.Point(188, 47);
            this.btnCOMportsRefresh.Name = "btnCOMportsRefresh";
            this.btnCOMportsRefresh.Size = new System.Drawing.Size(65, 23);
            this.btnCOMportsRefresh.TabIndex = 2;
            this.btnCOMportsRefresh.Text = "Refresh";
            this.btnCOMportsRefresh.UseVisualStyleBackColor = true;
            this.btnCOMportsRefresh.Click += new System.EventHandler(this.btnCOMportsRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "COM Ports:";
            // 
            // comboBoxCOMports
            // 
            this.comboBoxCOMports.FormattingEnabled = true;
            this.comboBoxCOMports.Location = new System.Drawing.Point(77, 50);
            this.comboBoxCOMports.Name = "comboBoxCOMports";
            this.comboBoxCOMports.Size = new System.Drawing.Size(105, 21);
            this.comboBoxCOMports.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baud rate:";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(77, 10);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(105, 21);
            this.comboBoxBaudRate.Sorted = true;
            this.comboBoxBaudRate.TabIndex = 0;
            // 
            // LANsettingsTab
            // 
            this.LANsettingsTab.Location = new System.Drawing.Point(4, 22);
            this.LANsettingsTab.Name = "LANsettingsTab";
            this.LANsettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LANsettingsTab.Size = new System.Drawing.Size(259, 87);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 215);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSelectGFile);
            this.groupBox2.Controls.Add(this.txtBoxFileSelected);
            this.groupBox2.Location = new System.Drawing.Point(12, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 66);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job";
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(371, 204);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(140, 23);
            this.btnSendData.TabIndex = 17;
            this.btnSendData.Text = "Send data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnXup
            // 
            this.btnXup.Location = new System.Drawing.Point(115, 271);
            this.btnXup.Name = "btnXup";
            this.btnXup.Size = new System.Drawing.Size(28, 58);
            this.btnXup.TabIndex = 18;
            this.btnXup.Text = "X up";
            this.btnXup.UseVisualStyleBackColor = true;
            // 
            // tbXdown
            // 
            this.tbXdown.Location = new System.Drawing.Point(114, 419);
            this.tbXdown.Name = "tbXdown";
            this.tbXdown.Size = new System.Drawing.Size(29, 20);
            this.tbXdown.TabIndex = 19;
            // 
            // btnXdown
            // 
            this.btnXdown.Location = new System.Drawing.Point(115, 355);
            this.btnXdown.Name = "btnXdown";
            this.btnXdown.Size = new System.Drawing.Size(28, 58);
            this.btnXdown.TabIndex = 18;
            this.btnXdown.Text = "X down";
            this.btnXdown.UseVisualStyleBackColor = true;
            // 
            // tbYup
            // 
            this.tbYup.Location = new System.Drawing.Point(213, 330);
            this.tbYup.Name = "tbYup";
            this.tbYup.Size = new System.Drawing.Size(29, 20);
            this.tbYup.TabIndex = 19;
            // 
            // tbXup
            // 
            this.tbXup.Location = new System.Drawing.Point(115, 248);
            this.tbXup.Name = "tbXup";
            this.tbXup.Size = new System.Drawing.Size(29, 20);
            this.tbXup.TabIndex = 19;
            // 
            // btnYdown
            // 
            this.btnYdown.Location = new System.Drawing.Point(51, 325);
            this.btnYdown.Name = "btnYdown";
            this.btnYdown.Size = new System.Drawing.Size(58, 28);
            this.btnYdown.TabIndex = 18;
            this.btnYdown.Text = "Y down";
            this.btnYdown.UseVisualStyleBackColor = true;
            // 
            // tbYdown
            // 
            this.tbYdown.Location = new System.Drawing.Point(16, 330);
            this.tbYdown.Name = "tbYdown";
            this.tbYdown.Size = new System.Drawing.Size(29, 20);
            this.tbYdown.TabIndex = 19;
            // 
            // btnYup
            // 
            this.btnYup.Location = new System.Drawing.Point(149, 325);
            this.btnYup.Name = "btnYup";
            this.btnYup.Size = new System.Drawing.Size(58, 28);
            this.btnYup.TabIndex = 18;
            this.btnYup.Text = "Y up";
            this.btnYup.UseVisualStyleBackColor = true;
            // 
            // btnZup
            // 
            this.btnZup.Location = new System.Drawing.Point(265, 271);
            this.btnZup.Name = "btnZup";
            this.btnZup.Size = new System.Drawing.Size(28, 58);
            this.btnZup.TabIndex = 18;
            this.btnZup.Text = "Z up";
            this.btnZup.UseVisualStyleBackColor = true;
            // 
            // btnZdown
            // 
            this.btnZdown.Location = new System.Drawing.Point(265, 355);
            this.btnZdown.Name = "btnZdown";
            this.btnZdown.Size = new System.Drawing.Size(28, 58);
            this.btnZdown.TabIndex = 18;
            this.btnZdown.Text = "Z down";
            this.btnZdown.UseVisualStyleBackColor = true;
            // 
            // tbZdown
            // 
            this.tbZdown.Location = new System.Drawing.Point(264, 419);
            this.tbZdown.Name = "tbZdown";
            this.tbZdown.Size = new System.Drawing.Size(29, 20);
            this.tbZdown.TabIndex = 19;
            // 
            // tbZup
            // 
            this.tbZup.Location = new System.Drawing.Point(265, 248);
            this.tbZup.Name = "tbZup";
            this.tbZup.Size = new System.Drawing.Size(29, 20);
            this.tbZup.TabIndex = 19;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 578);
            this.Controls.Add(this.tbYdown);
            this.Controls.Add(this.tbZup);
            this.Controls.Add(this.tbXup);
            this.Controls.Add(this.tbYup);
            this.Controls.Add(this.tbZdown);
            this.Controls.Add(this.tbXdown);
            this.Controls.Add(this.btnYup);
            this.Controls.Add(this.btnYdown);
            this.Controls.Add(this.btnZdown);
            this.Controls.Add(this.btnXdown);
            this.Controls.Add(this.btnZup);
            this.Controls.Add(this.btnXup);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.testTextbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnXup;
        private System.Windows.Forms.TextBox tbXdown;
        private System.Windows.Forms.Button btnXdown;
        private System.Windows.Forms.TextBox tbYup;
        private System.Windows.Forms.TextBox tbXup;
        private System.Windows.Forms.Button btnYdown;
        private System.Windows.Forms.TextBox tbYdown;
        private System.Windows.Forms.Button btnYup;
        private System.Windows.Forms.Button btnZup;
        private System.Windows.Forms.Button btnZdown;
        private System.Windows.Forms.TextBox tbZdown;
        private System.Windows.Forms.TextBox tbZup;
    }
}


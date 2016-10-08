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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMoveZ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbAbsolute = new System.Windows.Forms.RadioButton();
            this.rbRelative = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelZposition = new System.Windows.Forms.Label();
            this.labelYposition = new System.Windows.Forms.Label();
            this.labelXposition = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ConnectionSettings.SuspendLayout();
            this.USBsettingsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(1884, 24);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1884, 22);
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
            this.btnConnect.Size = new System.Drawing.Size(182, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect to the device";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // testTextbox
            // 
            this.testTextbox.Location = new System.Drawing.Point(442, 49);
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
            this.ConnectionSettings.Size = new System.Drawing.Size(267, 112);
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
            this.USBsettingsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.USBsettingsTab.Size = new System.Drawing.Size(259, 86);
            this.USBsettingsTab.TabIndex = 0;
            this.USBsettingsTab.Text = "USB Settings";
            // 
            // btnCOMportsRefresh
            // 
            this.btnCOMportsRefresh.Location = new System.Drawing.Point(187, 50);
            this.btnCOMportsRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCOMportsRefresh.Name = "btnCOMportsRefresh";
            this.btnCOMportsRefresh.Size = new System.Drawing.Size(49, 19);
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
            this.LANsettingsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.LANsettingsTab.Size = new System.Drawing.Size(259, 86);
            this.LANsettingsTab.TabIndex = 1;
            this.LANsettingsTab.Text = "LAN settings";
            this.LANsettingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.ConnectionSettings);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 208);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(199, 177);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(69, 23);
            this.btnDisconnect.TabIndex = 15;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSelectGFile);
            this.groupBox2.Controls.Add(this.txtBoxFileSelected);
            this.groupBox2.Location = new System.Drawing.Point(11, 250);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 66);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job";
            // 
            // btnSendData
            // 
            this.btnSendData.Enabled = false;
            this.btnSendData.Location = new System.Drawing.Point(196, 58);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(71, 78);
            this.btnSendData.TabIndex = 17;
            this.btnSendData.Text = "Send data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tbMoveX
            // 
            this.tbMoveX.Location = new System.Drawing.Point(80, 60);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(100, 20);
            this.tbMoveX.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Move X axis:";
            // 
            // tbMoveY
            // 
            this.tbMoveY.Location = new System.Drawing.Point(80, 87);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(100, 20);
            this.tbMoveY.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Move Y axis:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(80, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Move X axis:";
            // 
            // tbMoveZ
            // 
            this.tbMoveZ.Location = new System.Drawing.Point(80, 113);
            this.tbMoveZ.Name = "tbMoveZ";
            this.tbMoveZ.Size = new System.Drawing.Size(100, 20);
            this.tbMoveZ.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Move Z axis:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rbAbsolute);
            this.groupBox3.Controls.Add(this.rbRelative);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Controls.Add(this.tbMoveZ);
            this.groupBox3.Controls.Add(this.tbMoveX);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbMoveY);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(11, 321);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 147);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manual control";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Type:";
            // 
            // rbAbsolute
            // 
            this.rbAbsolute.AutoSize = true;
            this.rbAbsolute.Location = new System.Drawing.Point(151, 23);
            this.rbAbsolute.Name = "rbAbsolute";
            this.rbAbsolute.Size = new System.Drawing.Size(66, 17);
            this.rbAbsolute.TabIndex = 20;
            this.rbAbsolute.TabStop = true;
            this.rbAbsolute.Text = "Absolute";
            this.rbAbsolute.UseVisualStyleBackColor = true;
            // 
            // rbRelative
            // 
            this.rbRelative.AutoSize = true;
            this.rbRelative.Location = new System.Drawing.Point(81, 23);
            this.rbRelative.Name = "rbRelative";
            this.rbRelative.Size = new System.Drawing.Size(64, 17);
            this.rbRelative.TabIndex = 20;
            this.rbRelative.TabStop = true;
            this.rbRelative.Text = "Relative";
            this.rbRelative.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelZposition);
            this.groupBox4.Controls.Add(this.labelYposition);
            this.groupBox4.Controls.Add(this.labelXposition);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(11, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 122);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current position";
            // 
            // labelZposition
            // 
            this.labelZposition.AutoSize = true;
            this.labelZposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZposition.Location = new System.Drawing.Point(49, 82);
            this.labelZposition.Name = "labelZposition";
            this.labelZposition.Size = new System.Drawing.Size(60, 16);
            this.labelZposition.TabIndex = 1;
            this.labelZposition.Text = "0,00000";
            // 
            // labelYposition
            // 
            this.labelYposition.AutoSize = true;
            this.labelYposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYposition.Location = new System.Drawing.Point(49, 56);
            this.labelYposition.Name = "labelYposition";
            this.labelYposition.Size = new System.Drawing.Size(60, 16);
            this.labelYposition.TabIndex = 1;
            this.labelYposition.Text = "0,00000";
            // 
            // labelXposition
            // 
            this.labelXposition.AutoSize = true;
            this.labelXposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXposition.Location = new System.Drawing.Point(49, 28);
            this.labelXposition.Name = "labelXposition";
            this.labelXposition.Size = new System.Drawing.Size(60, 16);
            this.labelXposition.TabIndex = 1;
            this.labelXposition.Text = "0,00000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(23, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Z :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(23, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Y :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(23, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "X :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 655);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.testTextbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMoveZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbAbsolute;
        private System.Windows.Forms.RadioButton rbRelative;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelZposition;
        private System.Windows.Forms.Label labelYposition;
        private System.Windows.Forms.Label labelXposition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}


namespace FX5U_COM_TESTER
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.comboStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboDataBits = new System.Windows.Forms.ComboBox();
            this.comboBaudRate = new System.Windows.Forms.ComboBox();
            this.comboPortName = new System.Windows.Forms.ComboBox();
            this.spPLC = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetPLCType = new System.Windows.Forms.Button();
            this.btnPLC_STOP = new System.Windows.Forms.Button();
            this.btnPLC_RUN = new System.Windows.Forms.Button();
            this.rabHEX = new System.Windows.Forms.RadioButton();
            this.rabASCII = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearDisplay = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReadDevices = new System.Windows.Forms.Button();
            this.txtReadDeviceCount = new System.Windows.Forms.TextBox();
            this.txtReadPLCDevice = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnWriteDevice = new System.Windows.Forms.Button();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWritePLCDevice = new System.Windows.Forms.TextBox();
            this.txtWriteDeviceCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.comboStopBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboParity);
            this.groupBox1.Controls.Add(this.comboDataBits);
            this.groupBox1.Controls.Add(this.comboBaudRate);
            this.groupBox1.Controls.Add(this.comboPortName);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serail Port Setting";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(17, 161);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(143, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // comboStopBits
            // 
            this.comboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStopBits.FormattingEnabled = true;
            this.comboStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboStopBits.Location = new System.Drawing.Point(74, 111);
            this.comboStopBits.Name = "comboStopBits";
            this.comboStopBits.Size = new System.Drawing.Size(86, 20);
            this.comboStopBits.TabIndex = 9;
            this.comboStopBits.SelectedIndexChanged += new System.EventHandler(this.comboStopBits_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "StopBits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataBits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PortName:";
            // 
            // comboParity
            // 
            this.comboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboParity.Location = new System.Drawing.Point(74, 138);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(86, 20);
            this.comboParity.TabIndex = 4;
            this.comboParity.SelectedIndexChanged += new System.EventHandler(this.comboParity_SelectedIndexChanged);
            // 
            // comboDataBits
            // 
            this.comboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDataBits.FormattingEnabled = true;
            this.comboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboDataBits.Location = new System.Drawing.Point(74, 82);
            this.comboDataBits.Name = "comboDataBits";
            this.comboDataBits.Size = new System.Drawing.Size(86, 20);
            this.comboDataBits.TabIndex = 3;
            this.comboDataBits.SelectedIndexChanged += new System.EventHandler(this.comboDataBits_SelectedIndexChanged);
            // 
            // comboBaudRate
            // 
            this.comboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaudRate.FormattingEnabled = true;
            this.comboBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            ""});
            this.comboBaudRate.Location = new System.Drawing.Point(74, 53);
            this.comboBaudRate.Name = "comboBaudRate";
            this.comboBaudRate.Size = new System.Drawing.Size(86, 20);
            this.comboBaudRate.TabIndex = 2;
            this.comboBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBaudRate_SelectedIndexChanged);
            // 
            // comboPortName
            // 
            this.comboPortName.FormattingEnabled = true;
            this.comboPortName.Location = new System.Drawing.Point(74, 25);
            this.comboPortName.Name = "comboPortName";
            this.comboPortName.Size = new System.Drawing.Size(86, 20);
            this.comboPortName.TabIndex = 1;
            this.comboPortName.SelectedIndexChanged += new System.EventHandler(this.comboPortName_SelectedIndexChanged);
            // 
            // spPLC
            // 
            this.spPLC.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPLC_DataReceived);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDisplay);
            this.groupBox2.Location = new System.Drawing.Point(210, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(6, 18);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(700, 182);
            this.txtDisplay.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetPLCType);
            this.groupBox3.Controls.Add(this.btnPLC_STOP);
            this.groupBox3.Controls.Add(this.btnPLC_RUN);
            this.groupBox3.Location = new System.Drawing.Point(27, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnGetPLCType
            // 
            this.btnGetPLCType.Location = new System.Drawing.Point(17, 87);
            this.btnGetPLCType.Name = "btnGetPLCType";
            this.btnGetPLCType.Size = new System.Drawing.Size(143, 29);
            this.btnGetPLCType.TabIndex = 5;
            this.btnGetPLCType.Text = "GET PLC TYPE";
            this.btnGetPLCType.UseVisualStyleBackColor = true;
            this.btnGetPLCType.Click += new System.EventHandler(this.btnGetPLCType_Click);
            // 
            // btnPLC_STOP
            // 
            this.btnPLC_STOP.Location = new System.Drawing.Point(17, 52);
            this.btnPLC_STOP.Name = "btnPLC_STOP";
            this.btnPLC_STOP.Size = new System.Drawing.Size(143, 29);
            this.btnPLC_STOP.TabIndex = 4;
            this.btnPLC_STOP.Text = "PLC STOP";
            this.btnPLC_STOP.UseVisualStyleBackColor = true;
            this.btnPLC_STOP.Click += new System.EventHandler(this.btnPLC_STOP_Click);
            // 
            // btnPLC_RUN
            // 
            this.btnPLC_RUN.Location = new System.Drawing.Point(17, 20);
            this.btnPLC_RUN.Name = "btnPLC_RUN";
            this.btnPLC_RUN.Size = new System.Drawing.Size(143, 29);
            this.btnPLC_RUN.TabIndex = 3;
            this.btnPLC_RUN.Text = "PLC RUN";
            this.btnPLC_RUN.UseVisualStyleBackColor = true;
            this.btnPLC_RUN.Click += new System.EventHandler(this.btnPLC_RUN_Click);
            // 
            // rabHEX
            // 
            this.rabHEX.AutoSize = true;
            this.rabHEX.Location = new System.Drawing.Point(19, 24);
            this.rabHEX.Name = "rabHEX";
            this.rabHEX.Size = new System.Drawing.Size(89, 16);
            this.rabHEX.TabIndex = 3;
            this.rabHEX.Text = "Display HEX";
            this.rabHEX.UseVisualStyleBackColor = true;
            // 
            // rabASCII
            // 
            this.rabASCII.AutoSize = true;
            this.rabASCII.Checked = true;
            this.rabASCII.Location = new System.Drawing.Point(19, 52);
            this.rabASCII.Name = "rabASCII";
            this.rabASCII.Size = new System.Drawing.Size(101, 16);
            this.rabASCII.TabIndex = 4;
            this.rabASCII.TabStop = true;
            this.rabASCII.Text = "Display ASCII";
            this.rabASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearDisplay);
            this.groupBox4.Controls.Add(this.rabASCII);
            this.groupBox4.Controls.Add(this.rabHEX);
            this.groupBox4.Location = new System.Drawing.Point(772, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 116);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Setting";
            // 
            // btnClearDisplay
            // 
            this.btnClearDisplay.Location = new System.Drawing.Point(7, 74);
            this.btnClearDisplay.Name = "btnClearDisplay";
            this.btnClearDisplay.Size = new System.Drawing.Size(131, 29);
            this.btnClearDisplay.TabIndex = 6;
            this.btnClearDisplay.Text = "Cleard Display";
            this.btnClearDisplay.UseVisualStyleBackColor = true;
            this.btnClearDisplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnReadDevices);
            this.groupBox5.Controls.Add(this.txtReadDeviceCount);
            this.groupBox5.Controls.Add(this.txtReadPLCDevice);
            this.groupBox5.Location = new System.Drawing.Point(216, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 54);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Read ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Device Count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "PLC Device:";
            // 
            // btnReadDevices
            // 
            this.btnReadDevices.Location = new System.Drawing.Point(413, 20);
            this.btnReadDevices.Name = "btnReadDevices";
            this.btnReadDevices.Size = new System.Drawing.Size(131, 29);
            this.btnReadDevices.TabIndex = 7;
            this.btnReadDevices.Text = "Read Device";
            this.btnReadDevices.UseVisualStyleBackColor = true;
            this.btnReadDevices.Click += new System.EventHandler(this.btnReadDevices_Click);
            // 
            // txtReadDeviceCount
            // 
            this.txtReadDeviceCount.Location = new System.Drawing.Point(276, 23);
            this.txtReadDeviceCount.Name = "txtReadDeviceCount";
            this.txtReadDeviceCount.Size = new System.Drawing.Size(33, 21);
            this.txtReadDeviceCount.TabIndex = 1;
            this.txtReadDeviceCount.Text = "1";
            // 
            // txtReadPLCDevice
            // 
            this.txtReadPLCDevice.Location = new System.Drawing.Point(92, 23);
            this.txtReadPLCDevice.Name = "txtReadPLCDevice";
            this.txtReadPLCDevice.Size = new System.Drawing.Size(65, 21);
            this.txtReadPLCDevice.TabIndex = 0;
            this.txtReadPLCDevice.Text = "D1616";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnWriteDevice);
            this.groupBox6.Controls.Add(this.txtWriteValue);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtWritePLCDevice);
            this.groupBox6.Controls.Add(this.txtWriteDeviceCount);
            this.groupBox6.Location = new System.Drawing.Point(216, 311);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(550, 56);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Write";
            // 
            // btnWriteDevice
            // 
            this.btnWriteDevice.Location = new System.Drawing.Point(442, 17);
            this.btnWriteDevice.Name = "btnWriteDevice";
            this.btnWriteDevice.Size = new System.Drawing.Size(102, 29);
            this.btnWriteDevice.TabIndex = 12;
            this.btnWriteDevice.Text = "Write Device";
            this.btnWriteDevice.UseVisualStyleBackColor = true;
            this.btnWriteDevice.Click += new System.EventHandler(this.btnWriteDevice_Click);
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(362, 23);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(65, 21);
            this.txtWriteValue.TabIndex = 17;
            this.txtWriteValue.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "Device Count:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "PLC Device:";
            // 
            // txtWritePLCDevice
            // 
            this.txtWritePLCDevice.Location = new System.Drawing.Point(92, 25);
            this.txtWritePLCDevice.Name = "txtWritePLCDevice";
            this.txtWritePLCDevice.Size = new System.Drawing.Size(65, 21);
            this.txtWritePLCDevice.TabIndex = 12;
            this.txtWritePLCDevice.Text = "D1616";
            // 
            // txtWriteDeviceCount
            // 
            this.txtWriteDeviceCount.Location = new System.Drawing.Point(274, 25);
            this.txtWriteDeviceCount.Name = "txtWriteDeviceCount";
            this.txtWriteDeviceCount.Size = new System.Drawing.Size(33, 21);
            this.txtWriteDeviceCount.TabIndex = 13;
            this.txtWriteDeviceCount.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 379);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboDataBits;
        private System.Windows.Forms.ComboBox comboBaudRate;
        private System.Windows.Forms.ComboBox comboPortName;
        private System.IO.Ports.SerialPort spPLC;
        private System.Windows.Forms.ComboBox comboStopBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetPLCType;
        private System.Windows.Forms.Button btnPLC_STOP;
        private System.Windows.Forms.Button btnPLC_RUN;
        private System.Windows.Forms.RadioButton rabHEX;
        private System.Windows.Forms.RadioButton rabASCII;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearDisplay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReadDevices;
        private System.Windows.Forms.TextBox txtReadDeviceCount;
        private System.Windows.Forms.TextBox txtReadPLCDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWriteDevice;
        private System.Windows.Forms.TextBox txtWriteValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWritePLCDevice;
        private System.Windows.Forms.TextBox txtWriteDeviceCount;
    }
}


namespace ProjectConfig.View.PopForms
{
    partial class FrmEquipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipments));
            this.btn_SaveDevice = new System.Windows.Forms.Button();
            this.txt_EquipmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ProtocalType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grb_Internet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.grb_SerialPort = new System.Windows.Forms.GroupBox();
            this.cmb_StopBit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Parity = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_Baudrate = new System.Windows.Forms.ComboBox();
            this.cmb_SerialNumber = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grb_OPC = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_OPCServerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_OPCNodeName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Comment = new System.Windows.Forms.TextBox();
            this.chk_isEnable = new System.Windows.Forms.CheckBox();
            this.cmb_EquipmentType = new System.Windows.Forms.ComboBox();
            this.grb_Internet.SuspendLayout();
            this.grb_SerialPort.SuspendLayout();
            this.grb_OPC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaveDevice
            // 
            this.btn_SaveDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_SaveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveDevice.ForeColor = System.Drawing.Color.White;
            this.btn_SaveDevice.Image = global::ProjectConfig.Properties.Resources.add1;
            this.btn_SaveDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveDevice.Location = new System.Drawing.Point(607, 393);
            this.btn_SaveDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveDevice.Name = "btn_SaveDevice";
            this.btn_SaveDevice.Size = new System.Drawing.Size(112, 37);
            this.btn_SaveDevice.TabIndex = 5;
            this.btn_SaveDevice.Text = "增加新设备";
            this.btn_SaveDevice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveDevice.UseVisualStyleBackColor = false;
            this.btn_SaveDevice.Click += new System.EventHandler(this.btn_SaveDevice_Click);
            // 
            // txt_EquipmentName
            // 
            this.txt_EquipmentName.Location = new System.Drawing.Point(469, 19);
            this.txt_EquipmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_EquipmentName.Name = "txt_EquipmentName";
            this.txt_EquipmentName.Size = new System.Drawing.Size(250, 26);
            this.txt_EquipmentName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "项目名称：";
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbl_ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ProjectName.Location = new System.Drawing.Point(104, 19);
            this.lbl_ProjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(253, 29);
            this.lbl_ProjectName.TabIndex = 6;
            this.lbl_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "设备名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "设备类型：";
            // 
            // cmb_ProtocalType
            // 
            this.cmb_ProtocalType.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_ProtocalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProtocalType.FormattingEnabled = true;
            this.cmb_ProtocalType.Location = new System.Drawing.Point(469, 53);
            this.cmb_ProtocalType.Name = "cmb_ProtocalType";
            this.cmb_ProtocalType.Size = new System.Drawing.Size(250, 28);
            this.cmb_ProtocalType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "协议类型：";
            // 
            // grb_Internet
            // 
            this.grb_Internet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb_Internet.Controls.Add(this.label7);
            this.grb_Internet.Controls.Add(this.txt_Port);
            this.grb_Internet.Controls.Add(this.label6);
            this.grb_Internet.Controls.Add(this.txt_IPAddress);
            this.grb_Internet.Location = new System.Drawing.Point(12, 94);
            this.grb_Internet.Name = "grb_Internet";
            this.grb_Internet.Size = new System.Drawing.Size(728, 82);
            this.grb_Internet.TabIndex = 12;
            this.grb_Internet.TabStop = false;
            this.grb_Internet.Text = "以太网配置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "端口号：";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(457, 32);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(250, 26);
            this.txt_Port.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "IP地址：";
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(92, 32);
            this.txt_IPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(253, 26);
            this.txt_IPAddress.TabIndex = 8;
            // 
            // grb_SerialPort
            // 
            this.grb_SerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb_SerialPort.Controls.Add(this.cmb_StopBit);
            this.grb_SerialPort.Controls.Add(this.label11);
            this.grb_SerialPort.Controls.Add(this.cmb_Parity);
            this.grb_SerialPort.Controls.Add(this.label10);
            this.grb_SerialPort.Controls.Add(this.cmb_Baudrate);
            this.grb_SerialPort.Controls.Add(this.cmb_SerialNumber);
            this.grb_SerialPort.Controls.Add(this.label8);
            this.grb_SerialPort.Controls.Add(this.label9);
            this.grb_SerialPort.Location = new System.Drawing.Point(12, 182);
            this.grb_SerialPort.Name = "grb_SerialPort";
            this.grb_SerialPort.Size = new System.Drawing.Size(728, 82);
            this.grb_SerialPort.TabIndex = 13;
            this.grb_SerialPort.TabStop = false;
            this.grb_SerialPort.Text = "串口配置";
            // 
            // cmb_StopBit
            // 
            this.cmb_StopBit.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StopBit.FormattingEnabled = true;
            this.cmb_StopBit.Location = new System.Drawing.Point(571, 32);
            this.cmb_StopBit.Name = "cmb_StopBit";
            this.cmb_StopBit.Size = new System.Drawing.Size(89, 28);
            this.cmb_StopBit.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "停止位：";
            // 
            // cmb_Parity
            // 
            this.cmb_Parity.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Parity.FormattingEnabled = true;
            this.cmb_Parity.Location = new System.Drawing.Point(415, 32);
            this.cmb_Parity.Name = "cmb_Parity";
            this.cmb_Parity.Size = new System.Drawing.Size(89, 28);
            this.cmb_Parity.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "校验位：";
            // 
            // cmb_Baudrate
            // 
            this.cmb_Baudrate.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Baudrate.FormattingEnabled = true;
            this.cmb_Baudrate.Location = new System.Drawing.Point(256, 32);
            this.cmb_Baudrate.Name = "cmb_Baudrate";
            this.cmb_Baudrate.Size = new System.Drawing.Size(89, 28);
            this.cmb_Baudrate.TabIndex = 13;
            // 
            // cmb_SerialNumber
            // 
            this.cmb_SerialNumber.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_SerialNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SerialNumber.FormattingEnabled = true;
            this.cmb_SerialNumber.Location = new System.Drawing.Point(92, 32);
            this.cmb_SerialNumber.Name = "cmb_SerialNumber";
            this.cmb_SerialNumber.Size = new System.Drawing.Size(89, 28);
            this.cmb_SerialNumber.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "波特率：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "串口号：";
            // 
            // grb_OPC
            // 
            this.grb_OPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grb_OPC.Controls.Add(this.label12);
            this.grb_OPC.Controls.Add(this.txt_OPCServerName);
            this.grb_OPC.Controls.Add(this.label13);
            this.grb_OPC.Controls.Add(this.txt_OPCNodeName);
            this.grb_OPC.Location = new System.Drawing.Point(12, 270);
            this.grb_OPC.Name = "grb_OPC";
            this.grb_OPC.Size = new System.Drawing.Size(728, 82);
            this.grb_OPC.TabIndex = 14;
            this.grb_OPC.TabStop = false;
            this.grb_OPC.Text = "OPC配置";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "服务器名：";
            // 
            // txt_OPCServerName
            // 
            this.txt_OPCServerName.Location = new System.Drawing.Point(457, 32);
            this.txt_OPCServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OPCServerName.Name = "txt_OPCServerName";
            this.txt_OPCServerName.Size = new System.Drawing.Size(250, 26);
            this.txt_OPCServerName.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 9;
            this.label13.Text = "节点名称：";
            // 
            // txt_OPCNodeName
            // 
            this.txt_OPCNodeName.Location = new System.Drawing.Point(92, 32);
            this.txt_OPCNodeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OPCNodeName.Name = "txt_OPCNodeName";
            this.txt_OPCNodeName.Size = new System.Drawing.Size(253, 26);
            this.txt_OPCNodeName.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 363);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "备注：";
            // 
            // txt_Comment
            // 
            this.txt_Comment.Location = new System.Drawing.Point(87, 360);
            this.txt_Comment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Comment.Multiline = true;
            this.txt_Comment.Name = "txt_Comment";
            this.txt_Comment.Size = new System.Drawing.Size(374, 93);
            this.txt_Comment.TabIndex = 15;
            // 
            // chk_isEnable
            // 
            this.chk_isEnable.AutoSize = true;
            this.chk_isEnable.Location = new System.Drawing.Point(493, 400);
            this.chk_isEnable.Name = "chk_isEnable";
            this.chk_isEnable.Size = new System.Drawing.Size(84, 24);
            this.chk_isEnable.TabIndex = 17;
            this.chk_isEnable.Text = "是否启用";
            this.chk_isEnable.UseVisualStyleBackColor = true;
            // 
            // cmb_EquipmentType
            // 
            this.cmb_EquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EquipmentType.FormattingEnabled = true;
            this.cmb_EquipmentType.Location = new System.Drawing.Point(104, 53);
            this.cmb_EquipmentType.Name = "cmb_EquipmentType";
            this.cmb_EquipmentType.Size = new System.Drawing.Size(253, 28);
            this.cmb_EquipmentType.TabIndex = 18;
            // 
            // FrmEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 467);
            this.Controls.Add(this.cmb_EquipmentType);
            this.Controls.Add(this.chk_isEnable);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Comment);
            this.Controls.Add(this.grb_OPC);
            this.Controls.Add(this.grb_SerialPort);
            this.Controls.Add(this.grb_Internet);
            this.Controls.Add(this.cmb_ProtocalType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ProjectName);
            this.Controls.Add(this.btn_SaveDevice);
            this.Controls.Add(this.txt_EquipmentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设备管理";
            this.grb_Internet.ResumeLayout(false);
            this.grb_Internet.PerformLayout();
            this.grb_SerialPort.ResumeLayout(false);
            this.grb_SerialPort.PerformLayout();
            this.grb_OPC.ResumeLayout(false);
            this.grb_OPC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveDevice;
        private System.Windows.Forms.TextBox txt_EquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_ProtocalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grb_Internet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.GroupBox grb_SerialPort;
        private System.Windows.Forms.ComboBox cmb_StopBit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Parity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_Baudrate;
        private System.Windows.Forms.ComboBox cmb_SerialNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grb_OPC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_OPCServerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_OPCNodeName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.CheckBox chk_isEnable;
        private System.Windows.Forms.ComboBox cmb_EquipmentType;
    }
}
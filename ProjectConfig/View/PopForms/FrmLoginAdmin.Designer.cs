namespace ProjectConfig.View.PopForms
{
    partial class FrmLoginAdmin
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
            this.spc_Main = new System.Windows.Forms.SplitContainer();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.chkPwdSave = new System.Windows.Forms.CheckBox();
            this.txt_AdminPwd = new System.Windows.Forms.TextBox();
            this.txt_SysAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).BeginInit();
            this.spc_Main.Panel1.SuspendLayout();
            this.spc_Main.Panel2.SuspendLayout();
            this.spc_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // spc_Main
            // 
            this.spc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Main.Location = new System.Drawing.Point(0, 0);
            this.spc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.spc_Main.Name = "spc_Main";
            this.spc_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_Main.Panel1
            // 
            this.spc_Main.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.spc_Main.Panel1.Controls.Add(this.btn_Close);
            this.spc_Main.Panel1.Controls.Add(this.label1);
            // 
            // spc_Main.Panel2
            // 
            this.spc_Main.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.spc_Main.Panel2.Controls.Add(this.btn_Login);
            this.spc_Main.Panel2.Controls.Add(this.chkPwdSave);
            this.spc_Main.Panel2.Controls.Add(this.txt_AdminPwd);
            this.spc_Main.Panel2.Controls.Add(this.txt_SysAccount);
            this.spc_Main.Panel2.Controls.Add(this.label3);
            this.spc_Main.Panel2.Controls.Add(this.label2);
            this.spc_Main.Size = new System.Drawing.Size(390, 298);
            this.spc_Main.SplitterDistance = 110;
            this.spc_Main.SplitterWidth = 1;
            this.spc_Main.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(361, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(29, 29);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "上 位 机 配 置 软 件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(144, 126);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(175, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登 录 系 统";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Login_MouseDown);
            // 
            // chkPwdSave
            // 
            this.chkPwdSave.AutoSize = true;
            this.chkPwdSave.Checked = true;
            this.chkPwdSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPwdSave.Location = new System.Drawing.Point(53, 132);
            this.chkPwdSave.Name = "chkPwdSave";
            this.chkPwdSave.Size = new System.Drawing.Size(84, 24);
            this.chkPwdSave.TabIndex = 2;
            this.chkPwdSave.Text = "记住密码";
            this.chkPwdSave.UseVisualStyleBackColor = true;
            // 
            // txt_AdminPwd
            // 
            this.txt_AdminPwd.Location = new System.Drawing.Point(148, 71);
            this.txt_AdminPwd.Name = "txt_AdminPwd";
            this.txt_AdminPwd.PasswordChar = '*';
            this.txt_AdminPwd.Size = new System.Drawing.Size(171, 26);
            this.txt_AdminPwd.TabIndex = 1;
            // 
            // txt_SysAccount
            // 
            this.txt_SysAccount.Location = new System.Drawing.Point(148, 29);
            this.txt_SysAccount.Name = "txt_SysAccount";
            this.txt_SysAccount.Size = new System.Drawing.Size(171, 26);
            this.txt_SysAccount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "管理员密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "管理员账号：";
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 298);
            this.Controls.Add(this.spc_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLoginAdmin_MouseDown);
            this.spc_Main.Panel1.ResumeLayout(false);
            this.spc_Main.Panel1.PerformLayout();
            this.spc_Main.Panel2.ResumeLayout(false);
            this.spc_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).EndInit();
            this.spc_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_Main;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox chkPwdSave;
        private System.Windows.Forms.TextBox txt_AdminPwd;
        private System.Windows.Forms.TextBox txt_SysAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
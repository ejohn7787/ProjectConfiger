namespace ProjectConfig.View.PopForms
{
    partial class FrmProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjects));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.btn_AddProject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Location = new System.Drawing.Point(105, 40);
            this.txt_ProjectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(250, 26);
            this.txt_ProjectName.TabIndex = 1;
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btn_AddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProject.ForeColor = System.Drawing.Color.White;
            this.btn_AddProject.Image = global::ProjectConfig.Properties.Resources.add1;
            this.btn_AddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddProject.Location = new System.Drawing.Point(245, 81);
            this.btn_AddProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.Size = new System.Drawing.Size(112, 37);
            this.btn_AddProject.TabIndex = 2;
            this.btn_AddProject.Text = "增加新项目";
            this.btn_AddProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddProject.UseVisualStyleBackColor = false;
            this.btn_AddProject.Click += new System.EventHandler(this.btn_AddProject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "提示：输入后按回车键即可保存。";
            // 
            // FrmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AddProject);
            this.Controls.Add(this.txt_ProjectName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmProjects";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "项目信息管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Button btn_AddProject;
        private System.Windows.Forms.Label label2;
    }
}
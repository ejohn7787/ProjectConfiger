using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormMoveByMouse;
using zj.BLL;
using zj.Models;

namespace ProjectConfig.View.PopForms
{
   
    public partial class FrmLoginAdmin : Form
    {
        private SysAdminsManager sysAdminsManager = new SysAdminsManager();

        private MoveByMouse moveByMouse = new MoveByMouse();
        
        public FrmLoginAdmin()
        {
            InitializeComponent();
            //读取上次保存的登录信息
            SysAdmins sysAdmins = sysAdminsManager.ReadPwd();
            if(sysAdmins !=null)
            {
                this.txt_AdminPwd.Text = sysAdmins.AdminPwd;
                this.txt_SysAccount.Text = sysAdmins.SysAccount;
                this.chkPwdSave.Checked= true;
            }
            else
            {
                this.txt_AdminPwd.Clear();
                this.txt_SysAccount.Clear();
                this.chkPwdSave.Checked = false;
                this.txt_SysAccount .Focus();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btn_Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmLoginAdmin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            moveByMouse.MouseLeftButtonDown(e);
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Point? newPoint = moveByMouse.MouseMove(e);
            if(newPoint != null)
            {
                this.Location = (Point)newPoint;
               
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            //验证判断输入
            if (txt_SysAccount.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_SysAccount.Focus();
                return;
            }

            if (txt_AdminPwd.Text.Trim().Length == 0) 
            {
                MessageBox.Show("请输入登录密码", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txt_AdminPwd.Focus();
                return;
            }

           
            //封装模型类
            SysAdmins sysAdmins = new SysAdmins();
            sysAdmins.SysAccount= txt_SysAccount.Text.Trim();
            sysAdmins.AdminPwd = txt_AdminPwd.Text.Trim();
            //封装业务逻辑
           
            try
            {
                sysAdmins = sysAdminsManager.AdminLogin(sysAdmins);

            }
            catch(Exception ex)
            {
                //写入日志
                //......
                //显示错误对话框
                MessageBox.Show(ex.Message, "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //验证登录是否成功
            if(sysAdmins != null)
            {
                //保存当前的用户对象
                Program.currentAdmin= sysAdmins;
                //处理其他的要求的动作。

                //保存用户登录信息，简化下次的登录
                if(this.chkPwdSave.Checked )
                {
                    sysAdminsManager.SavePwd(sysAdmins);
                }
                else
                {
                    sysAdminsManager.DeletePwd();
                }

                //设置窗体的返回值
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // 账号或密码错误
                MessageBox.Show("登录账号和密码错误", "登录错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            


        }
    }
}

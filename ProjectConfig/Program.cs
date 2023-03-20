using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectConfig.View;
using ProjectConfig.View.PopForms;
using zj.Common;
using zj.Models;

namespace ProjectConfig
{
    internal static class Program
    {
        //用于保存当前用户的变量
        public static SysAdmins currentAdmin = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string connectString = "Data Source=MYHP\\SQLEXPRESS;Initial Catalog=ProjectConfigDB;Persist Security Info=True;User ID=sa;Password=sa";
            //加密后的字符串
            //string cnn = StringSecurity.DESEncrypt(connectString);
            ////解密后的字符串
            //string cnn2 = StringSecurity.DESDecrypt(cnn);

            FrmLoginAdmin frmLogin = new FrmLoginAdmin();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

        }
    }
}

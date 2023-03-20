using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;
using zj.Models;
namespace zj.BLL
{

    public class SysAdminsManager
    {
        private SysAdiminsService sysAdiminsService = new SysAdiminsService();
        public SysAdmins AdminLogin(SysAdmins sysAdmins)
        {
            return sysAdiminsService.AdminLogin(sysAdmins);
        }

        /// <summary>
        /// 保存用户对象的数据
        /// </summary>
        /// <param name="sysAdmins"></param>
        public void SavePwd(SysAdmins sysAdmins)
        {
             sysAdiminsService.SavePwd(sysAdmins);
        }
        /// <summary>
        /// 读取密码
        /// </summary>
        /// <returns></returns>
        public SysAdmins ReadPwd()
        {
           return sysAdiminsService.ReadPwd();
        }
        /// <summary>
        /// 清除密码
        /// </summary>
        public void DeletePwd()
        {
            sysAdiminsService.DeletePwd();
        }
    }
}

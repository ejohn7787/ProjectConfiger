using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using zj.Models;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
namespace zj.DAL
{
    /// <summary>
    /// 管理员登录数据访问类
    /// </summary>
    public class SysAdiminsService
    {
        /// <summary>
        /// 用户登录用数据查询，考虑以后的扩展和功能的变化，最好输入和返回参数都用实体类。
        /// </summary>
        /// <param name="sysAdmins">输入实体类，包含登录的账号和密码</param>
        /// <returns>返回用户信息</returns>
        public SysAdmins AdminLogin(SysAdmins sysAdmins)
        {
            //拼接SQL语句
            string sql = "SELECT SysAdminId,AdminName FROM SysAdmins WHERE SysAccount=@SysAccount AND AdminPwd=@AdminPwd";
            //封装参数数组
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@SysAccount",sysAdmins.SysAccount),
                new SqlParameter("@AdminPwd",sysAdmins.AdminPwd)
            };
            SqlDataReader sqlDataReader = null;
            //提交查询
            try
            {
                sqlDataReader = SQLHelper.ExecuteReader(sql, sqlParameters);
                if (sqlDataReader.Read())     //登录账号密码正确 read()方法返回true
                {
                    sysAdmins.SysAdminId = Convert.ToInt32(sqlDataReader["SysAdminId"]);
                    sysAdmins.AdminName = (string)sqlDataReader["AdminName"];
                }
                else
                {
                    sysAdmins=null;   //当前登录信息不正确
                }
            }
            catch (Exception ex)
            {
                throw new Exception("执行AdminLogin方法时出错，原因：" + ex.Message);
            }
            finally
            {
                sqlDataReader.Close();
            }
            return sysAdmins;
            


        }
        /// <summary>
        /// 保存用户对象的数据
        /// </summary>
        /// <param name="sysAdmins"></param>
        public void SavePwd(SysAdmins sysAdmins)
        {
            //创建文件流
            FileStream fileStream = new FileStream("sysadmins.obj",FileMode.Create);
            //创建二进制格式化器
            BinaryFormatter binaryFormatter= new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, sysAdmins); //把内存中的对象保存到文件
            fileStream.Close();        //保存
        }
        /// <summary>
        /// 读取密码
        /// </summary>
        /// <returns></returns>
        public SysAdmins ReadPwd()
        {
            //判断文件是否存在
            if( !File .Exists("sysadmins.obj"))
            {
                return null;
            }
            FileStream fileStream = new FileStream("sysadmins.obj", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            SysAdmins sysAdmins = (SysAdmins)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return sysAdmins;
        }
        /// <summary>
        /// 清除密码
        /// </summary>
        public void DeletePwd()
        {
            if (File.Exists("sysadmins.obj"))
            {
                File.Delete("sysadmins.obj");
            }
        }

    }
}

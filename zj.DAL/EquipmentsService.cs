using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using zj.Models;

namespace zj.DAL
{
    /// <summary>
    /// 设备类型和协议类型的查询
    /// </summary>
    public class EquipmentsService
    {

        /// <summary>
        /// 获取所有的设备类型
        /// </summary>
        /// <returns></returns>
        public List<EquipmentType> GetAllEtype()
        {
            string sql = "SELECT EtypeId ,EtypeName FROM EquipmentType ";
            List<EquipmentType> list = new List<EquipmentType>();
            SqlDataReader sqlDataReader = SQLHelper.ExecuteReader(sql, null);
            while (sqlDataReader.Read())
            {
                list.Add(new EquipmentType
                {
                    EtypeId = Convert.ToInt32(sqlDataReader["EtypeId"]),
                    EtypeName = sqlDataReader["EtypeName"].ToString()

                });
            }
            sqlDataReader.Close();
            return list;
        }

        /// <summary>
        /// 根据设备类型来获取对应的协议类型
        /// </summary>
        /// <param name="etypeId"></param>
        /// <returns></returns>
        public List<ProtocalType> GetProtocalTypesByEtypeId(int etypeId)
        {
            string sql = "SELECT PtypeId ,PtypeName FROM ProtocalType  WHERE EtypeId = @EtypeId ";
            SqlParameter[] sqlParameters = {
                new SqlParameter("EtypeId",etypeId),
            };
            List<ProtocalType> protocalTypes = new List<ProtocalType>();
            SqlDataReader sqlDataReader = SQLHelper.ExecuteReader(sql, sqlParameters);
            while (sqlDataReader.Read())
            {
                protocalTypes.Add(new ProtocalType
                {
                    PtypeId = Convert.ToInt32(sqlDataReader["PtypeId"]),
                    PtypeName = sqlDataReader["PtypeName"].ToString()
                });
            }
            sqlDataReader.Close();
            return protocalTypes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;
using zj.Models;

namespace zj.BLL
{
    public  class EquipmentsManager
    {
        private EquipmentsService equipmentsService = new EquipmentsService();
        /// <summary>
        /// 获取所有的设备类型
        /// </summary>
        /// <returns></returns>
        public List<EquipmentType> GetAllEtype()
        {
           return  equipmentsService.GetAllEtype();
        }

        /// <summary>
        /// 根据设备类型来获取对应的协议类型
        /// </summary>
        /// <param name="etypeId"></param>
        /// <returns></returns>
        public List<ProtocalType> GetProtocalTypesByEtypeId(int etypeId)
        {
            return equipmentsService.GetProtocalTypesByEtypeId(etypeId);
        }
    }
}

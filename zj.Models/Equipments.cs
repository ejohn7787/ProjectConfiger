using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.Models
{
    public class Equipments
    {
        public int SN { get; set; }
        public int EquipmentId { get;set; } 
        public int ProjectId { get; set; }
        public string EquipmentName { get; set; }
        public int ETypeId { get; set; }
        public int PTypeId { get; set; } 
        
        //数据库中选填项的处理
        public string IpAddress { get; set; }=string .Empty;
        public string PortNo { get; set; }=string .Empty;
        public string SerialNo { get; set; } = string.Empty;
        public int BaudRate { get; set; } = 0;
        public int DataBit { get; set; } = 0;
        public int ParityBit { get; set; } = 0;
        public int StopBit { get; set; } = 0;
        public string OPCNodeNme { get; set; }= string .Empty;
        public string OPCServerName { get; set; }=string .Empty;
        public int IsEnable { get; set; } = 0;
        public string Comments { get; set; } = string.Empty;


        //扩展属性
        public string ETypeName { get; set; }
        public string PTypeName { get; set; }

    }
}

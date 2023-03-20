using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.Models
{
    public class CommunicationGroup
    {
        public int SN { get; set; }
        public int CGId { get; set; }
        public int EquipmentId { get; set; }
        public string CGName { get; set; }
        public string StartAddress { get; set; }
        public int CGLength { get; set; }
        public int IsEnable { get; set; }
        public string Comments { get; set; }

        //扩展属性,用于外键处理
        public string EquipmentName { get; set; }
    }
}

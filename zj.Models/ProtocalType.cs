using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.Models
{
    public class ProtocalType
    {
        public int SN { get; set; }
        public int PtypeId { get; set; }
        public int EtypeId { get; set; }
        public string PtypeName { get; set; }

        // 扩展属性
        public string EtypeName { get; set; }
    }
}

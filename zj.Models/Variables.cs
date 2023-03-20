using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zj.Models
{
    public class Variables
    {
        public int SN { get; set; }
        public int VariableId { get; set; }
        public string VariableName { get; set; }
        public int CGId { get; set; }
        public string StartAddress { get; set; }
        public string DataType { get; set; }
        public bool IsMaxAlarm { get; set; }
        public bool IsMinAlarm { get; set;}
        public string AlarmMax { get; set; }=string.Empty;
        public string AlarmMin { get; set;} =string.Empty;
        public bool IsFiled { get; set; }
        public float Scale { get; set; }
        public float Offset { get; set; }
        public string Comments { get; set; }
        public string AlarmMaxNode { get; set; } = string.Empty;
        public string AlarmMinNode { get;set; } = string.Empty;
    }
}

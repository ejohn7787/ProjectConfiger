using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.BLL;
using zj.Models;
namespace ProjectConfig.View.PopForms
{
    public partial class FrmEquipments : Form
    {
        private Projects project = null;
        private EquipmentsManager equipmentsManager = new EquipmentsManager();
        public FrmEquipments()
        {
            InitializeComponent();
            //整体复位
            GroupBoxReset();
            //绑定设备类型
            this.cmb_EquipmentType.DataSource = equipmentsManager.GetAllEtype();
            this.cmb_EquipmentType.DisplayMember = "EtypeName";
            this.cmb_EquipmentType.ValueMember = "EtypeId";
            this.cmb_EquipmentType.SelectedIndex = -1;
            //如果有控件级联查询，下一级的事件绑定要在上一级初始化完成后才进行
            this.cmb_EquipmentType.SelectedIndexChanged += new System.EventHandler(this.cmb_EquipmentType_SelectedIndexChanged);
        }

        public FrmEquipments(Projects value): this()
        {
            this.project = value;
            this.lbl_ProjectName.Text = this.project.ProjectName;
        }
        private void btn_SaveDevice_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_EquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //分组框整体复位
            GroupBoxReset();
            //根据选择显示
            if (this.cmb_EquipmentType.Text.ToString().Contains("以太网"))
            {
                grb_Internet.Enabled = true;
                grb_Internet.BackColor=Color.FromArgb(146,160,166);       
                
            }
            else if(this.cmb_EquipmentType.Text.ToString().Contains("串口"))
            {
                grb_SerialPort.Enabled = true;
                grb_SerialPort.BackColor = Color.FromArgb(146, 160, 166);
               
            }
            else if (this.cmb_EquipmentType.Text.ToString().Contains("OPC"))
            {
                grb_OPC.Enabled = true;
                grb_OPC.BackColor = Color.FromArgb(146, 160, 166);
               
            }
            //设备类型选项更改后触发协议类型选项的变化
            int eTypeId = Convert.ToInt32(this.cmb_EquipmentType.SelectedValue);
            this.cmb_ProtocalType.DataSource = equipmentsManager.GetProtocalTypesByEtypeId(eTypeId);
            this.cmb_ProtocalType.DisplayMember = "PtypeName";
            this.cmb_ProtocalType.ValueMember = "PtypeId";
            this.cmb_ProtocalType.SelectedIndex =0;

        }
        private void GroupBoxReset()
        {
            //整体复位
            grb_SerialPort.BackColor = Color.FromArgb(192, 255, 255);
            grb_OPC.BackColor = Color.FromArgb(192, 255, 255);
            grb_Internet.BackColor = Color.FromArgb(192, 255, 255);
            grb_SerialPort.Enabled = grb_Internet.Enabled = grb_OPC.Enabled = false;
        }
    }
}

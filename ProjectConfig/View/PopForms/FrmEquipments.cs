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
        private EquipmentsManager equipmentsManager = new EquipmentsManager();
        public FrmEquipments()
        {
            InitializeComponent();
            //绑定设备类型
            this.cmb_EquipmentType.DataSource = equipmentsManager.GetAllEtype();
            this.cmb_EquipmentType.DisplayMember = "EtypeName";
            this.cmb_EquipmentType.ValueMember = "EtypeId";
            this.cmb_EquipmentType.SelectedIndex = -1;
            //如果有控件级联查询，下一级的事件绑定要在上一级初始化完成后才进行
            this.cmb_EquipmentType.SelectedIndexChanged += new System.EventHandler(this.cmb_EquipmentType_SelectedIndexChanged);
        }

        private void btn_SaveDevice_Click(object sender, EventArgs e)
        {

        }

        private void cmb_EquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int eTypeId = Convert.ToInt32(this.cmb_EquipmentType.SelectedValue);
            this.cmb_ProtocalType.DataSource = equipmentsManager.GetProtocalTypesByEtypeId(eTypeId);
            this.cmb_ProtocalType.DisplayMember = "PtypeName";
            this.cmb_ProtocalType.ValueMember = "PtypeId";
            this.cmb_ProtocalType.SelectedIndex =0;

        }
    }
}

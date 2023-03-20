using ProjectConfig.View.PopForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.Models;
using zj.BLL;

namespace ProjectConfig.View
{
    public partial class FrmMain : Form
    {
        private List<Projects> projects = new List<Projects>();  //保存当前的项目列表
        private ProjectsManager projectsManager = new ProjectsManager();
        public FrmMain()
        {
            InitializeComponent();
            dgv_Projects.AutoGenerateColumns = false;  //禁止自动生成列
            //显示当前的用户对象
            tslbl_AdiminName.Text = Program.currentAdmin.AdminName;
            //显示所有的项目信息
            dgv_ProjectIni();


        }
        /// <summary>
        /// 窗体关闭时，询问是否关闭。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("确认退出吗？","退出询问 ：",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;   //窗体取消关闭
            }
           

        }
        //创建新项目
        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            FrmProjects frmProjects = new FrmProjects();
            DialogResult dialogResult =  frmProjects.ShowDialog();
            if(dialogResult == DialogResult.OK) // 添加成功
            {
                Projects newProject = (Projects)frmProjects.Tag;    //获取返回的对象
                newProject.SN = projects.Count + 1; //添加序列项
                projects.Add(newProject);
                dgv_Projects.DataSource = null;
                dgv_Projects.DataSource = projects;
            }
        }
        private void dgv_ProjectIni()
        {
            projects = projectsManager.Query();
            if(projects.Count== 0) //如果没有数据
            {
                btn_DelProject.Enabled = false;
                btn_RenameProject.Enabled = false;
                dgv_Projects.DataSource = null;
            }
            else   
            {
                btn_DelProject.Enabled = true;
                btn_RenameProject.Enabled = true;
                dgv_Projects.DataSource= projects;
            }
        }

        private void btn_RenameProject_Click(object sender, EventArgs e)
        {
            //获取当前选择的ID号
            int pid = Convert.ToInt32(dgv_Projects.CurrentRow.Cells["ProjectId"].Value);
            //在项目集合中查找对应的ID的项目对象
            Projects model = null;
            for(int i=0;i< projects.Count;i++)
            {
                if (projects[i].ProjectId == pid)
                {
                    model = projects[i]; 
                    break;
                }
            }
            //打开修改窗体，并把要修改的对象导入，
            FrmProjects frmProjects = new FrmProjects(model);
            DialogResult dialogResult = frmProjects.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                //引用类型，所以只需要修改这个对象。就修改了集合里的内容。
                model.ProjectName = frmProjects.Tag.ToString(); 
                this.dgv_Projects.Refresh();      //刷新表格
            }

        }

        private void btn_DelProject_Click(object sender, EventArgs e)
        {
            //获取当前选择的ID号
            int pid = Convert.ToInt32(dgv_Projects.CurrentRow.Cells["ProjectId"].Value);
            //查找
            Projects project = projects.Where(p => p.ProjectId == pid).ToList()[0];
            //删除确认,
            if(  MessageBox.Show("删除当前选中的项目吗？删除时会把设备，通信组，变量信息一同删除！",
                "删除警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.Cancel )
            {
                return;
            }
            //数据库删除
            try
            {
                projectsManager.Delete(pid);
            }
            catch(Exception ex ) 
            {
                MessageBox.Show("数据删除失败，原因：" + ex.Message);
                return;
            }

            //集合中删除
            projects.Remove(project);
            dgv_Projects.DataSource = null;
            if(projects.Count > 0)  //如果对象大于0，可以绑定，否则出错，点击DGV时出现-1错误
            {
                dgv_Projects.DataSource = projects;
            }
            
        }

        private void btn_AddEquipment_Click(object sender, EventArgs e)
        {
            FrmEquipments frmEquipments = new FrmEquipments();
            DialogResult dialogResult = frmEquipments.ShowDialog();
        }
    }
}

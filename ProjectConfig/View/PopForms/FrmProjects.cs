using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zj.BLL;
using zj.Models;

namespace ProjectConfig.View.PopForms
{
    public partial class FrmProjects : Form
    {
        private Projects project = null;
        private ProjectsManager projectsManager = new ProjectsManager();
        /// <summary>
        /// 插入时调用的构造函数
        /// </summary>
        public FrmProjects()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 修改时调用的构造函数
        /// </summary>
        /// <param name="model"></param>
        public FrmProjects(Projects model) : this()    //调用前执行冒号后的方法
        {
            btn_AddProject.Text = "重命名项目";
            this.Text = "项目信息管理-重命名项目";
            this.project = model;            //需要修改的实例内容
            txt_ProjectName.Text = model.ProjectName;
        }

        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            //数据验证
            if (txt_ProjectName.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入项目信息！", "提示信息");
                txt_ProjectName.Focus();
                return;
            }

            //封装对象
            Projects projects = new Projects
            {
                ProjectName = txt_ProjectName.Text.Trim() //把需要修改或插入的对象名称写入对象
            };


            if (this.project == null)  //如果对象为空，就增加
            {
                InsertModel(projects);
            }
            else
            {
                UpdateModel(projects);
            }


        }
        /// <summary>
        /// 插入对象
        /// </summary>
        /// <param name="model"></param>
        private void InsertModel(Projects model)
        {
            try
            {
                //调用业务逻辑
                if (projectsManager.isRepeatForInsert(model.ProjectName))
                {
                    //重复了
                    MessageBox.Show("项目名称已经存在！", "提示信息");
                    this.txt_ProjectName.SelectAll();
                    return;
                }
                else
                {
                    //不重复
                    model.ProjectId = projectsManager.InsertProject(model);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误，错误原因：" + ex.Message);
                return;
            }
            this.Tag = model;
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="model">新的内容</param>
        private void UpdateModel(Projects model)
        {
            try
            {
                //调用业务逻辑，工程名为修改后的名称，ID为传入的修改前的ID,
                //检查除了当前ID以外，其他ID号的工程名是否和新工程名重复
                if (projectsManager.isRepeatForUpdate(model.ProjectName, this.project.ProjectId))
                {
                    //重复了
                    MessageBox.Show("项目名称已经存在！", "提示信息");
                    this.txt_ProjectName.SelectAll();
                    return;

                }
                else
                {

                    //不重复
                    model.ProjectId = this.project.ProjectId;  //把老的ID写入新的ID
                    projectsManager.Update(model);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作错误，错误原因：" + ex.Message);
                return;
            }
            this.Tag = model.ProjectName;
            this.DialogResult = DialogResult.OK;
        }

    }
}

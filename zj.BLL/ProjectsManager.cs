using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using zj.DAL;
using zj.Models;
namespace zj.BLL
{
    public class ProjectsManager
    {
        ProjectsService ProjectsService = new ProjectsService();
        /// <summary>
        /// 新增项目，并返回新增项目的ID号
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int InsertProject(Projects project)
        {
            return ProjectsService. InsertProject(project);
        }
        /// <summary>
        /// 验证插入的工程是否重复
        /// （老师这么写，我觉得判断似乎可以放入BLL库中，作为插入的判断DAL库只要增加一个查找函数就可以了）
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public bool isRepeatForInsert(string pName)
        {
           return ProjectsService.isRepeatForInsert(pName);
        }
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int Update(Projects project)
        {
            return ProjectsService.Update(project);
        }
        /// <summary>
        /// 验证修改名称的工程是否和除了自己以外的其他项重复
        /// （老师这么写，我觉得判断似乎可以放入BLL库中，作为插入的判断DAL库只要增加一个查找函数就可以了）
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pId"></param>
        /// <returns></returns>
        public bool isRepeatForUpdate(string pName, int pId)
        {
           return ProjectsService.isRepeatForUpdate(pName, pId);
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
             return ProjectsService.Delete(id);
        }
        /// <summary>
        /// 查询表到集合。
        /// </summary>
        /// <returns></returns>
        public List<Projects> Query()
        {
            return ProjectsService.Query();
        }
    }
}

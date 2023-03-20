using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zj.Models;
using System.Data;
using System.Web;
using System.Data.SqlClient;

namespace zj.DAL
{
    public  class ProjectsService
    {
        /// <summary>
        /// 新增项目，并返回新增项目的ID号
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int InsertProject(Projects project)
        {
            string sql = "INSERT INTO Projects (ProjectName) VALUES(@ProjectName);SELECT @@Identity";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ProjectName",project.ProjectName),

            };
            return Convert.ToInt32( SQLHelper.ExecuteScalar(sql, sp));
        }
        /// <summary>
        /// 验证插入的工程是否重复
        /// （老师这么写，我觉得判断似乎可以放入BLL库中，作为插入的判断DAL库只要增加一个查找函数就可以了）
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public bool isRepeatForInsert(string pName)
        {
            string sql = "SELECT Count(*) FROM Projects WHERE ProjectName=@pName";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@pName",pName)
            };
            return  Convert.ToInt32( SQLHelper.ExecuteScalar(sql, sqlParameters)) == 0 ? false:true ;
        }
        /// <summary>
        /// 修改项目
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public int Update(Projects project)
        {
            string sql = "UPDATE Projects SET ProjectName = @ProjectName WHERE ProjectId = @ProjectId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ProjectName",project.ProjectName),
                new SqlParameter("@ProjectId",project.ProjectId)
            };
            return SQLHelper .ExecuteNonQuery(sql, sqlParameters);
        }
        /// <summary>
        /// 验证修改名称的工程是否和除了自己以外的其他项重复
        /// （老师这么写，我觉得判断似乎可以放入BLL库中，作为插入的判断DAL库只要增加一个查找函数就可以了）
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pId"></param>
        /// <returns></returns>
        public bool isRepeatForUpdate(string pName,int pId)
        {
            string sql = "SELECT Count(*) FROM Projects WHERE ProjectName=@pName AND ProjectId <> @ProjectId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@pName",pName),
                new SqlParameter("@ProjectId",pId)
            };
            return Convert.ToInt32(SQLHelper.ExecuteScalar(sql, sqlParameters)) == 0 ? false : true;
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            string sql = "DELETE FROM Projects WHERE ProjectId=@ProjectId";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ProjectId",id)

            };
            return SQLHelper.ExecuteNonQuery(sql, sp);
        }
        /// <summary>
        /// 查询表到集合。
        /// </summary>
        /// <returns></returns>
        public List<Projects> Query()
        {
            string sql = "SELECT ProjectName, ProjectId FROM Projects ORDER BY ProjectId ASC";
            SqlDataReader sqlDataReader = SQLHelper .ExecuteReader(sql);
            List<Projects> list = new List<Projects>();
            int sn = 0;
            while (sqlDataReader.Read())
            {
                sn++;
                list.Add(new Projects()
                {
                    SN= sn,
                    ProjectId =Convert.ToInt32 ( sqlDataReader["ProjectId"]),
                    ProjectName = sqlDataReader["ProjectName"].ToString(),
                });
            }
            sqlDataReader.Close();
            return list;
        }
    }
}

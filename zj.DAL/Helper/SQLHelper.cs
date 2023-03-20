using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration.Provider;
using System.Data.Common;
using zj.Common;
namespace zj.DAL
{
    internal class SQLHelper
    {
        //读取连接字符串
        private static string connectionString = StringSecurity.DESDecrypt( ConfigurationManager.ConnectionStrings["connString"].ToString() );
        /// <summary>
        /// 执行Insert,Update,Delete语句
        /// </summary>
        /// <param name="sql">sql语句或过程名称</param>
        /// <param name="sqlParameters">参数数组</param>
        /// <returns>受影响的行数</returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteNonQuery(string sql, SqlParameter[] sqlParameters = null)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            if(sqlParameters != null )
            {
                cmd.Parameters.AddRange(sqlParameters);
                
            }
            try
            {
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteNonQuery时出错。原因：" + ex.Message);
            }
            finally { sqlConnection.Close(); }

        }
        /// <summary>
        /// 聚合查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object ExecuteScalar(string sql, SqlParameter[] sqlParameters = null)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            try
            {
                sqlConnection.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteScalar时出错。原因：" + ex.Message);
            }
            finally { sqlConnection.Close(); }

        }
        /// <summary>
        /// 执行返回 Reader方法
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] sqlParameters = null)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            try
            {
                sqlConnection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteReader时出错。原因：" + ex.Message);
            }
        }
        /// <summary>
        /// 返回一张数据表的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(string sql,string tableName = null)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, sqlConnection);
            SqlDataAdapter sqlDataAdapter  = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                if(tableName == null)
                {
                    sqlDataAdapter.Fill(ds);
                }
                else
                {
                    sqlDataAdapter.Fill (ds, tableName);
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("执行ExecuteReader时出错。原因：" + ex.Message);
            }
            finally 
            { 
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// 查询包含多张数据表的数据集
        /// </summary>
        /// <param name="tableNameAndSql">数据表名和SQL语句一一对应的字典对象</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataSet GetDataSet(Dictionary<string, string> tableNameAndSql)
        {

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                sqlConnection.Open();
                foreach (string tableName in tableNameAndSql.Keys)
                {
                    cmd.CommandText = tableNameAndSql[tableName];
                    sqlDataAdapter.Fill(ds, tableName);
                }

                return ds;

            }
            catch (Exception ex)
            {
                //写入日志信息
                throw new Exception("执行GetDataSet方法发生异常！" + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}

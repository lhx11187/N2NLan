using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace N2NLanIP.Utils
{
    class SQLhelper
    {
        string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="Sqlstr">sql语句</param>
        /// <param name="errMsg">返回的错误</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Constring, string Sqlstr, ref string errMsg)
        {
            using (SqlConnection cnn = new SqlConnection(Constring))
            {
                cnn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(Sqlstr, cnn);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    errMsg = ex.ToString();
                    return 0;

                }
                finally
                {
                    cnn.Close();
                }
            }
        }
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Constring, string Sqlstr)
        {
            string errMsg = "";
            return ExecuteNonQuery(Constring, Sqlstr, ref errMsg);
        }
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Sqlstr)
        {
            //var conn=Extensions.ConfigurationManager.ConnectStr;
            //string Constring = conn;
            string Constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return ExecuteNonQuery(Constring, Sqlstr);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        //public void ExecuteNonQuery(string Sqlstr)
        //{
        //    string Constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        //    ExecuteNonQuery(Constring, Sqlstr);
        //}
        /// <summary>
        /// 执行sql语句返回一个DataTable
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="Sqlstr">sql语句</param>
        /// <param name="errMsg">返回的错误</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Constring, string Sqlstr, ref string errMsg)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(Constring))
            {
                cnn.Open();
                try
                {
                    SqlCommand com = new SqlCommand(Sqlstr, cnn);
                    com.CommandText = Sqlstr;
                    SqlDataAdapter sda = new SqlDataAdapter(com);
                    sda.Fill(dt);//填充数据
                }
                catch (Exception ex)
                {
                    errMsg = ex.ToString();
                    return new DataTable();

                }
                finally
                {
                    cnn.Close();
                }
            }
            return dt;

        }
        /// <summary>
        /// 执行sql语句返回一个DataTable
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Constring, string Sqlstr)
        {
            string errMsg = "";
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(Constring))
            {
                cnn.Open();
                try
                {
                    SqlCommand com = new SqlCommand(Sqlstr, cnn);
                    com.CommandText = Sqlstr;
                    SqlDataAdapter sda = new SqlDataAdapter(com);
                    DataSet ds=new DataSet();
                    sda.Fill(ds);
                    dt=ds.Tables[0];
                    //sda.Fill(dt);//填充数据
                }
                catch (Exception ex)
                {
                    errMsg = ex.ToString();
                    return new DataTable();

                }
                finally
                {
                    cnn.Close();
                }
            }
            return dt;

        }

        /// <summary>
        /// 执行sql语句返回一个DataTable
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Sqlstr)
        {
            //var conn=Extensions.ConfigurationManager.ConnectStr;
            string Constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return DataTableQuery(Constring, Sqlstr);
        }

        /// <summary>
        /// 调用存储过程返回DataTable
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="parameterValues">参数集</param>
        /// <param name="errMsg">返回结果</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string Constring, string cmdText, SqlParameter[] parameterValues, ref string errMsg)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();//打开数据库连接
                try
                {
                    SqlCommand cmd = new SqlCommand(cmdText, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parameterValues)
                    {
                        cmd.Parameters.Add(item);
                    }
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.SelectCommand.CommandTimeout = 70000;
                    dap.Fill(dt);
                    return dt;

                }
                catch (Exception ex)
                {
                    errMsg = ex.ToString();
                    return new DataTable();

                }
            }
        }

        /// <summary>
        /// 调用存储过程返回DataSet
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="parameterValues">参数集</param>
        /// <param name="errMsg">返回结果</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string Constring, string cmdText, SqlParameter[] parameterValues, ref string errMsg)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(Constring))
            {
                con.Open();//打开数据库连接
                try
                {
                    SqlCommand cmd = new SqlCommand(cmdText, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parameterValues)
                    {
                        cmd.Parameters.Add(item);
                    }
                    SqlDataAdapter dap = new SqlDataAdapter(cmd);
                    dap.SelectCommand.CommandTimeout = 70000;
                    dap.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    errMsg = ex.ToString();
                    return new DataSet();

                }
            }

        }

    }
}

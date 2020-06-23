using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data;


namespace mdc.Api.Utils
{
    class MySqlhelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string conf = Extensions.ConfigurationManager.ConnectStr;
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sqltext"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqltext)
        {
            conf=Extensions.ConfigurationManager.ConnectStr;
            using (MySqlConnection conn = new MySqlConnection(conf))
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand(sqltext, conn);
               return  comm.ExecuteScalar();
            }
        }
        /// <summary>
        /// 返回受影响行数
        /// </summary>
        /// <param name="sqltext"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset(string sqltext)
        {
            conf=Extensions.ConfigurationManager.ConnectStr;
            using (MySqlConnection conn = new MySqlConnection(conf))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqltext, conf);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        /// <summary>
        /// 返回dataset 传入sqlparameter
        /// </summary>
        /// <param name="sqltext"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset(string sqltext, MySql.Data.MySqlClient.MySqlParameter[] param)
        {
            conf=Extensions.ConfigurationManager.ConnectStr;
            using (MySqlConnection conn = new MySqlConnection(conf))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqltext,conn);
                //adapter.SelectCommand.Connection = conn;
                adapter.SelectCommand.CommandType = CommandType.Text;
              //  adapter.SelectCommand.CommandText = sqltext;
                adapter.SelectCommand.Parameters.AddRange(param);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
        //string constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="Sqlstr">sql语句</param>
        /// <param name="param">参数</param>
        /// <param name="errMsg">返回的错误</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Constring, string Sqlstr, MySql.Data.MySqlClient.MySqlParameter[] param, ref string errMsg)
        {
            Sqlstr = Sqlstr.Replace(@"\", @"\\"); // mysql 需要进行转义
            using (MySqlConnection cnn = new MySqlConnection(Constring))
            {
                cnn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(Sqlstr, cnn);
                    cmd.Parameters.AddRange(param);
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
        public int ExecuteNonQuery(string Constring, string Sqlstr,MySql.Data.MySqlClient.MySqlParameter[] param)
        {
            string errMsg = "";
            var rn = ExecuteNonQuery(Constring, Sqlstr, param , ref errMsg);
            //if (!string.IsNullOrWhiteSpace(errMsg))
            //{
            //    throw new Exception(errMsg);
            //}
            return rn;
        }
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Sqlstr)
        {
            var conn=Extensions.ConfigurationManager.ConnectStr;
            string Constring = conn;
            //string Constring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            return ExecuteNonQuery(Constring, Sqlstr,new MySql.Data.MySqlClient.MySqlParameter[]{});
        }
        /// <summary>
        /// 执行sql语句返回影响行数
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string Sqlstr ,MySql.Data.MySqlClient.MySqlParameter[] param)
        {
            var conn=Extensions.ConfigurationManager.ConnectStr;
            string Constring = conn;
            return ExecuteNonQuery(Constring, Sqlstr, param);
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
            using (MySqlConnection cnn = new MySqlConnection(Constring))
            {
                cnn.Open();
                try
                {
                    MySqlCommand com = new MySqlCommand(Sqlstr, cnn);
                    com.CommandText = Sqlstr;
                    MySqlDataAdapter sda = new MySqlDataAdapter(com);
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
        /// <param name="param">参数</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Constring, string Sqlstr,MySql.Data.MySqlClient.MySqlParameter[] param)
        {
            using (MySqlConnection cnn = new MySqlConnection(Constring))
            {
                cnn.Open();
                MySqlCommand com = new MySqlCommand(Sqlstr, cnn);
                com.Parameters.AddRange(param);
                com.CommandText = Sqlstr;
                MySqlDataAdapter sda = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cnn.Close();
                return dt;
            }
        }

        /// <summary>
        /// 执行sql语句返回一个DataTable
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Sqlstr)
        {
            var conn=Extensions.ConfigurationManager.ConnectStr;
            string Constring = conn;
            return DataTableQuery(Constring, Sqlstr,new MySql.Data.MySqlClient.MySqlParameter[]{});
        }
        /// <summary>
        /// 执行sql语句返回一个DataTable
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <param name="param">参数</param>
        /// <returns></returns>
        public DataTable DataTableQuery(string Sqlstr , MySql.Data.MySqlClient.MySqlParameter[] param )
        {
            var conn=Extensions.ConfigurationManager.ConnectStr;
            string Constring = conn;
            return DataTableQuery(Constring, Sqlstr,param);
        }
        /// <summary>
        /// 调用存储过程返回DataTable
        /// </summary>
        /// <param name="Constring">数据库连接字符串</param>
        /// <param name="cmdText">存储过程名称</param>
        /// <param name="parameterValues">参数集</param>
        /// <param name="errMsg">返回结果</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string Constring, string cmdText, MySql.Data.MySqlClient.MySqlParameter[] parameterValues, ref string errMsg)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(Constring))
            {
                con.Open();//打开数据库连接
                try
                {
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (MySql.Data.MySqlClient.MySqlParameter item in parameterValues)
                    {
                        cmd.Parameters.Add(item);
                    }
                    MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
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
        public DataSet ExecuteDataSet(string Constring, string cmdText, MySql.Data.MySqlClient.MySqlParameter[] parameterValues, ref string errMsg)
        {
            DataSet ds = new DataSet();
            using (MySqlConnection con = new MySqlConnection(Constring))
            {
                con.Open();//打开数据库连接
                try
                {
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (MySql.Data.MySqlClient.MySqlParameter item in parameterValues)
                    {
                        cmd.Parameters.Add(item);
                    }
                    MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
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

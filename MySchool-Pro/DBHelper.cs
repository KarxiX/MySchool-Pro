using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MySchool_Pro
{
    class DBHelper
    {
        //连接字符串
        private static readonly string constr = @"server=.;database=MySchool;Integrated Security = True";


        /// <summary>
        /// 单查询方法
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>查询第一行的第一列</returns>
        public static object ExecuteScalar(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                con.Open();//打开数据库连接
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)//错误处理模块
            {
                //弹窗错误信息
                MessageBox.Show("数据库连接发生异常"+ex.Message,"发生错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();//关闭数据库连接
            }
            return null;
        }



        /// <summary>
        /// 增删改方法
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>false:方法失败 true:方法成功</returns>
        public static bool ExecuteNonQuery(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();//打开数据库连接
                return cmd.ExecuteNonQuery()>0;
            }
            catch (Exception ex)//错误处理模块
            {
                //弹窗错误信息
                MessageBox.Show("数据库连接发生异常" + ex.Message, "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();//关闭数据库连接
            }
            return false;
            
        }





        /// <summary>
        /// 行查询方法
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>查询一行数据[要配合循环使用]</returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
              
                con.Open();//打开数据库连接
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);//阅读器关闭数据库连接也关闭
            }
            catch (Exception ex)//错误处理模块
            {
                //弹窗错误信息
                MessageBox.Show("数据库连接发生异常" + ex.Message, "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// 填充数据方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql)
        {
            //创建连接对象
            SqlConnection con = new SqlConnection(constr);
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //创建数据适配器
                DataSet ds = new DataSet();
                //sda.SelectCommand = cmd;
                //数据集
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)//错误处理模块
            {
                //弹窗错误信息
                MessageBox.Show("数据库连接发生异常" + ex.Message, "发生错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}

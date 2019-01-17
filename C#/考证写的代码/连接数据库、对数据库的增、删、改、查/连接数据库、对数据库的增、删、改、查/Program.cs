using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 连接数据库_对数据库的增_删_改_查
{
    class Program
    {
        static void Main(string[] args)
        {
            public class SqlHelper
        {
            //数据库连接词
            private static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ToString();

            /// <summary>
            /// SQL语句 无参查询
            /// </summary>
            /// <param name="sql">select 语句</param>
            /// <returns>返回SqlDataReader</returns>
            public static SqlDataReader Query(string sql)
            {
                SqlConnection conn = new SqlConnection(constr);
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    throw;
                }
            }

            /// <summary>
            /// SQL语句 有参查询
            /// </summary>
            /// <param name="sql">select 语句</param>
            /// <param name="para">SQL参数</param>
            /// <returns>返回SqlDataReader</returns>
            public static SqlDataReader Query(string sql, SqlParameter[] para)
            {
                SqlConnection conn = new SqlConnection(constr);
                try
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    throw;
                }
            }

            /// <summary>
            /// SQL语句 单一结果的无参查询
            /// </summary>
            /// <param name="sql">select 语句</param>
            /// <returns>返回 object</returns>
            public static object QueryScalar(string sql)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    return cmd.ExecuteScalar();
                }
            }

            /// <summary>
            /// SQL语句 单一结果的有参查询
            /// </summary>
            /// <param name="sql">select 语句</param>
            /// <param name="para">SQL参数</param>
            /// <returns>返回 object</returns>
            public static object QueryScalar(string sql, SqlParameter[] para)
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    return cmd.ExecuteScalar();
                }
            }

            /// <summary>
            /// SQL语句 无参增，删，改
            /// </summary>
            /// <param name="sql">insert,update,delete语句</param>
            /// <returns>返回影响的行数</returns>
            public static int NonQuery(string sql)
            {
                SqlConnection conn = new SqlConnection(constr);
                SqlTransaction tran = null;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Transaction = tran;
                    int i = cmd.ExecuteNonQuery();
                    tran.Commit();
                    return i;
                }
                catch
                {
                    if (tran != null)
                        tran.Rollback();
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            /// <summary>
            /// SQL语句 有参增，删，改
            /// </summary>
            /// <param name="sql">insert,update,delete语句</param>
            /// <param name="para">SQL参数</param>
            /// <returns>返回影响的行数</returns>
            public static int NonQuery(string sql, SqlParameter[] para)
            {
                SqlConnection conn = new SqlConnection(constr);
                SqlTransaction tran = null;
                try
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(para);
                    cmd.Transaction = tran;
                    int i = cmd.ExecuteNonQuery();
                    tran.Commit();
                    return i;
                }
                catch (Exception e)
                {
                    if (tran != null)
                        tran.Rollback();
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

    }
}
}

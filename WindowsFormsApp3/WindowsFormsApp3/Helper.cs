using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormsApp3
{
    class Helper
    {
        public static string connstr = "Server=desktop-add3gv7;Database=Students;Integrated Security=SSPI";
        public DataSet GetData(String Sqlstr)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand(Sqlstr,con);
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                dapt.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public  int Excute(string SqlStr)
        {
            try
            {
                int result = 0;
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                SqlCommand cmd = new SqlCommand(SqlStr, con);
                result = cmd.ExecuteNonQuery();//执行语句并返回受影响的行数
                con.Close();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int Excute(string SqlStr,SqlParameter[] param)
        {
            try
            {
                SqlConnection con = new SqlConnection(connstr);
                con.Open();
                SqlCommand cmd = new SqlCommand(SqlStr, con);
                cmd.Parameters.AddRange(param);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                return 0;
            }
        }

    }
}

using System.Data;
using MySql.Data.MySqlClient;

namespace myApp
{
    public class mysql
    {
        public static MySqlConnection con;      // to establish new connection with database
        public static MySqlCommand cmd;         // to execute commands and queries
        public static MySqlDataAdapter da;      // to fetch data from database
        public static MySqlDataReader dr;       // to read data from database row by row
        public static DataTable dt;             // to store table data temporarily
        public static DataSet ds;               // to store multiple tables from database

        public static string Conn_String
        {
            get
            {
                return $"server=localhost;port=3306;username=root;password=Noor2006;database=company;sslmode=None";
            }
        }

        public static void Query(string sql)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                con.Open();
                using (cmd = new MySqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetData(string sql)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                con.Open();
                dt = new DataTable();
                using (da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static DataSet GetDataSet(string sql)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                con.Open();
                ds = new DataSet();
                using (da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(ds);
                }
            }
            return ds;
        }
    }
}

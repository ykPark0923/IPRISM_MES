using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteMES.DBAccess
{
    static public class DBAccessor
    {
        static string strCon = "Server=127.0.0.1; Port=3406; Database=lottemes; uid=root; pwd=root;";

        static MySqlConnection m_cnn = null;

        static DBAccessor()
        {
            m_cnn = new MySqlConnection(strCon);
        }

        static public void Destroy()
        {
            m_cnn.Close();
        }

        public static DataTable Maria_Data(string strSql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                cmd.Connection = m_cnn;
                cmd.CommandText = strSql;
                cmd.CommandType = CommandType.Text;

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }
        }
    }
}

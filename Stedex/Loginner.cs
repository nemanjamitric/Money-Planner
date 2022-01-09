using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stedex
{
    internal class Loginner
    {
        private string email;
        private string pwd;


        

        public Loginner(string email, string pwd)
        {
            this.email = email;
            this.pwd = pwd;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetPwd()
        {
            return pwd;
        }

        SQLConn connection_info = new SQLConn();

        private SqlConnection getConnection()
        {
            return new SqlConnection(connection_info.GetConn());
        }


        public bool TryLogin()
        {
            string email, pwd;

            SqlConnection connection = getConnection();

            try
            {
                string select_querry = ("SELECT p_pwd from Persons where p_email = '" + this.GetEmail() + "' and  p_pwd = '" + this.GetPwd() + "'");
            
                SqlDataAdapter sda = new SqlDataAdapter(select_querry, connection);

                DataTable data_table = new DataTable();
                sda.Fill(data_table);

                if (data_table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

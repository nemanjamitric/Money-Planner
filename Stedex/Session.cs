using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stedex
{
    internal class Session
    {
        public static int id;
        public static string fname;
        public static string lname;
        public static string email;
        public static decimal money;
        public static decimal est_income;
        public static string message;

        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return fname;
        }

        public string GetLname()
        {
            return lname;
        }

        public string GetEmail()
        {
            return email;
        }

        public decimal GetMoney()
        {
            return money;
        }

        public decimal GetEstIncome()
        {
            return est_income;
        }

        public void SetEstIncome(decimal x)
        {
            est_income = x;
        }


        public void SetMessage(string msg)
        {
            message = msg;
        }
        public string DisplayMessage()
        {
            return message;
            message = "";
        }


        SQLConn connection_info = new SQLConn();

        private SqlConnection getConnection()
        {
            return new SqlConnection(connection_info.GetConn());
        }

        public void UpdatePersonsMoney(decimal x)
        {
            SqlConnection connection = getConnection();

            try
            {
                string update_query = ("UPDATE Persons SET p_money = " + x +" WHERE p_id = '" + id + "'");

                SqlCommand cmd = new SqlCommand(update_query, connection);
                SqlDataReader myReader;
                try
                {
                    connection.Open();
                    myReader = cmd.ExecuteReader();
                    while (myReader.Read())
                    {
                    }
                }
                catch (Exception ex)
                {
                    this.SetMessage(ex.Message);
                }
            }
            catch (SqlException ex)
            {
                this.SetMessage(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        

        public void AddExpenseHandler(decimal val, int subtype_id)
        {
            money -= val;
            this.UpdatePersonsMoney((decimal)money);
            string insert_query = "INSERT INTO Spendings (s_p_id, s_s_sbtype_id, s_amount, s_date) VALUES (" + id + ", " + subtype_id + ", " + val + ", '" + DateTime.Today + "')";

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(insert_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                this.SetMessage("Saved Expense");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                this.SetMessage(ex.Message);
            }
        }

        public void AddIncome(string about, decimal amount)
        {
            money += amount;

            this.UpdatePersonsMoney((decimal)money);

            string insert_query = "INSERT INTO Incomes (i_p_id, i_about, i_amount, i_date) VALUES (" + id + ", '" + about + "', " + amount + ", '" + DateTime.Today + "')";

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(insert_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                this.SetMessage("Updated Money");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                this.SetMessage(ex.Message);
            }
        }


        public void ResetSession()
        {
            id = 0;
            fname = null;
            lname = null;
            email = null;
            money = 0;
        }

        

        public void SetSession(string gottenmail)
        {

            SqlConnection connection = getConnection();

            string get_user_sql = "SELECT * FROM Persons WHERE p_email = '" + gottenmail + "'";

            SqlDataAdapter sda = new SqlDataAdapter(get_user_sql, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            foreach (DataRow row in data_table.Rows)
            {
                id = (int)row["p_id"];
                fname = row["p_fname"].ToString();
                lname = row["p_lname"].ToString();
                email = row["p_email"].ToString();
                money = (decimal)row["p_money"];
                est_income = (decimal)row["p_est_income"];
            }


        }
    }
}

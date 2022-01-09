using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stedex
{
    public partial class Estimated_Income : Form
    {
        public Estimated_Income()
        {
            InitializeComponent();
        }



        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session session = new Session();

            string update_query = "UPDATE Persons SET p_est_income = " + estIncBox.Value + " WHERE p_id = " + session.GetId();

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(update_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                session.SetMessage("Saved Estimation");
                session.SetEstIncome((decimal)estIncBox.Value);
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                session.SetMessage(ex.Message);
            }
            finally
            {
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }
    }
}

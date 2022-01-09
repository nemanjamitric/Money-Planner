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
    public partial class AddGoal : Form
    {
        public AddGoal()
        {
            InitializeComponent();
        }

        private void saveGoalBtn_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            if ((DateTime.Parse(goalDate.SelectionRange.Start.ToShortDateString()) - DateTime.Today).TotalDays > 0)
            {
                string insert_query = "INSERT INTO Goals (g_p_id, g_about, g_amount, g_date) VALUES (" + session.GetId() + ", '" + aboutTB.Text.Trim() + "', " + amountBox.Value + ", '" + DateTime.Parse(goalDate.SelectionRange.Start.ToShortDateString()) + "')";

                SQLConn sQLConn = new SQLConn();

                SqlConnection connection = new SqlConnection(sQLConn.GetConn());
                SqlCommand cmd = new SqlCommand(insert_query, connection);
                SqlDataReader myReader;
                try
                {
                    connection.Open();
                    myReader = cmd.ExecuteReader();
                    session.SetMessage("Saved Goal");
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
            } else
            {
                MessageBox.Show("Select date in the future.");
            }
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}

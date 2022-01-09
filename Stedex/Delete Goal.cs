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
    public partial class Delete_Goal : Form
    {
        Session session = new Session();

        
        public Delete_Goal()
        {
            InitializeComponent();
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {

            Main main = new Main();
            main.Show();
            this.Hide();
        }


        private void DeleteGoalBTN_Click(object sender, EventArgs e)
        {
            string delete_query = "DELETE FROM Goals WHERE g_id = " + goalsComboBox.Text.Substring(goalsComboBox.Text.Length - 20, 20).Trim();

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(delete_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                session.SetMessage("Deleted Goal");
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
                connection.Close();
                Main main = new Main();
                main.Show();
                this.Close();
            }
        }

        private void Delete_Goal_Load(object sender, EventArgs e)
        {
            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());

            string LoadGoalsSQL = "SELECT g_about AS YourGoal, g_date AS Date, g_amount AS Price, g_id  FROM Goals WHERE g_p_id = " + session.GetId() + " ORDER BY g_date ASC";

            SqlDataAdapter sda = new SqlDataAdapter(LoadGoalsSQL, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            goalsView.DataSource = data_table;

            foreach (DataRow row in data_table.Rows)
            {
                string x = row["YourGoal"].ToString() + "-";
                for (int i = 0; i < 20 - row["g_id"].ToString().Length; i++)
                {
                    x += " ";
                }
                x += row["g_id"].ToString();
                goalsComboBox.Items.Add(x);
            }
        }
    }
}

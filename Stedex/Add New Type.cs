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
    public partial class Add_New_Type : Form
    {
        public Add_New_Type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string insert_query = @"INSERT INTO SpendingTypes (s_type_name) VALUES ('" + typeNameTB.Text.Trim() + "')";

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(insert_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                Session session = new Session();
                session.SetMessage("Saved Type");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                Add_New_Expense_Subtype add_New_Expense_Subtype = new Add_New_Expense_Subtype();
                add_New_Expense_Subtype.Show();
                this.Close();
            }
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Add_New_Expense_Subtype xd = new Add_New_Expense_Subtype();
            xd.Show();
            this.Hide();
        }
    }
}

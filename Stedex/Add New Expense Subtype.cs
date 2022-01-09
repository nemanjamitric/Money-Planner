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
    public partial class Add_New_Expense_Subtype : Form
    {
        Session session = new Session();

        public Add_New_Expense_Subtype()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Type add_New_Type = new Add_New_Type();
            add_New_Type.Show();
            this.Close();
        }

        private void Add_New_Expense_Subtype_Load(object sender, EventArgs e)
        {
            string load_combobox = "SELECT * FROM SpendingTypes";
            SQLConn sQLConn = new SQLConn();
            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlDataAdapter sda = new SqlDataAdapter(load_combobox, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            foreach (DataRow row in data_table.Rows)
            {
                string x = row["s_type_name"].ToString() + "-";
                for(int i = 0; i < 20 - row["s_type_id"].ToString().Length; i++)
                {
                    x += " ";
                }
                x += row["s_type_id"].ToString();
                subtypesComboBox.Items.Add(x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insert_query = "INSERT INTO SpendingSubtypes (s_sbtype_name, s_sbtype_p_id, s_sbtype_nec, s_sbtype_s_type_id) VALUES ('" + subtypeNameTB.Text.Trim() + "', " + session.GetId() + ", " + necessityBar.Value + ", " + subtypesComboBox.Text.Substring(subtypesComboBox.Text.Length-20, 20).Trim() + ")";

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlCommand cmd = new SqlCommand(insert_query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmd.ExecuteReader();
                session.SetMessage("Saved Subtype");
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
                Add_Expense add_Expense = new Add_Expense();
                add_Expense.Show();
                this.Close();
            }
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Add_Expense add_Expense = new Add_Expense();
            add_Expense.Show();
            this.Hide();
        }

    }
}

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
    public partial class Add_Expense : Form
    {

        Session session = new Session();
        public Add_Expense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_New_Expense_Subtype add_New_Expense_Subtype = new Add_New_Expense_Subtype();
            add_New_Expense_Subtype.Show();
            this.Close();
        }

        private void Add_Expense_Load(object sender, EventArgs e)
        {
            messageLabel.Text = session.DisplayMessage();
            string load_combobox = "SELECT * FROM SpendingSubtypes";
            SQLConn sQLConn = new SQLConn();
            SqlConnection connection = new SqlConnection(sQLConn.GetConn());
            SqlDataAdapter sda = new SqlDataAdapter(load_combobox, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            foreach (DataRow row in data_table.Rows)
            {
                string x = row["s_sbtype_name"].ToString() + "-";
                for (int i = 0; i < 20 - row["s_sbtype_id"].ToString().Length; i++)
                {
                    x += " ";
                }
                x += row["s_sbtype_id"].ToString();
                artikliComboBox.Items.Add(x);
            }
        }

        private void saveExpenseBtn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(artikliComboBox.Text.Substring(artikliComboBox.Text.Length - 20, 20));
            session.AddExpenseHandler((decimal)priceBox.Value, x);
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}

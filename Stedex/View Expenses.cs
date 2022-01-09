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
    public partial class View_Expenses : Form
    {
        public View_Expenses()
        {
            InitializeComponent();
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void View_Expenses_Load(object sender, EventArgs e)
        {
            Session session = new Session();

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());

            string LoadGoalsSQL = "SELECT s_sbtype_name AS Expense, s_date AS Date, s_amount AS Amount, s_sbtype_nec AS Necessity FROM Spendings INNER JOIN SpendingSubtypes ON s_s_sbtype_id = s_sbtype_id WHERE s_p_id = " + session.GetId() + " ORDER BY s_date DESC";

            SqlDataAdapter sda = new SqlDataAdapter(LoadGoalsSQL, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            expensesView.DataSource = data_table;
        }
    }
}

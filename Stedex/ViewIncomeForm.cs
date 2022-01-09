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
    public partial class ViewIncomeForm : Form
    {
        public ViewIncomeForm()
        {
            InitializeComponent();
        }

        private void ViewIncomeForm_Load(object sender, EventArgs e)
        {
            Session session = new Session();

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());

            string LoadGoalsSQL = "SELECT i_about AS YourIncome, i_date AS Date, i_amount AS Amount FROM Incomes WHERE i_p_id = " + session.GetId() + " ORDER BY i_date DESC";

            SqlDataAdapter sda = new SqlDataAdapter(LoadGoalsSQL, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            incomesView.DataSource = data_table;
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}

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
using System.Windows.Forms.DataVisualization;

namespace Stedex
{
    public partial class Main : Form
    {
        Session session = new Session();

        public decimal allSpending;

        public Dictionary<int, decimal> sortedSpending = new Dictionary<int, decimal>();

        public Main()
        {
                InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {
            messageLabel.Text = session.DisplayMessage();
            personInfoText.Text = "Hello " + session.GetName() + " " + session.GetLname();
            moneyTB.Text = "Balance: " + session.GetMoney();
            monthlyIncomeLabel.Text = session.GetEstIncome().ToString();

            SQLConn sQLConn = new SQLConn();

            SqlConnection connection = new SqlConnection(sQLConn.GetConn());


            //UCITAVA TOP 3 CILJA

            string LoadGoalsSQL = "SELECT TOP 3 g_about AS YourGoal, g_date AS Date, g_amount AS Price FROM Goals WHERE g_p_id = " + session.GetId() + " ORDER BY g_date ASC";

            SqlDataAdapter sda = new SqlDataAdapter(LoadGoalsSQL, connection);

            DataTable data_table = new DataTable();
            sda.Fill(data_table);

            dataGridView1.DataSource = data_table;


            //UCITAVA GLAVNI CILJ
            if (data_table.Rows.Count > 0) {
                goalMoneyLabel.Text = "Your First Goal: " + data_table.Rows[0]["Price"].ToString();
                goalDateLabel.Text = "Your First Goal Date: " + data_table.Rows[0]["Date"].ToString().Substring(0, 10);

                DateTime today = DateTime.Now;
                DateTime goalDate = DateTime.Parse(data_table.Rows[0]["Date"].ToString());
                int daysLeft = (int)(goalDate - today).TotalDays;
                if (daysLeft == 0)
                {
                    daysLeft = 1;
                }


                targetSpendingLabel.Text = (Math.Round( ( ( ( (goalDate.Month - DateTime.Today.Month)  * session.GetEstIncome() ) - (decimal)data_table.Rows[0]["Price"] + session.GetMoney()) / daysLeft), 2)).ToString();
                if(targetSpendingLabel.Text.Contains('-'))
                {
                    targetSpendingLabel.Text = "Impossible";
                    MessageBox.Show("Please postpone your goal as it is impossible to reach.");
                    Delete_Goal delete_Goal = new Delete_Goal();
                    delete_Goal.Show();
                    this.Hide();
                }


                string load_10_day_spendings = "SELECT SUM(s_amount) AS Amount FROM Spendings WHERE s_p_id = " + session.GetId() + " AND s_date >= DATEADD(day, -10, GETDATE())";
                SqlDataAdapter sda4 = new SqlDataAdapter(load_10_day_spendings, connection);
                DataTable data_table4 = new DataTable();
                sda4.Fill(data_table4);

                decimal last10days = 0;
                if (data_table4.Rows[0]["Amount"] != null && data_table4.Rows[0]["Amount"] != DBNull.Value) {
                    last10days = (decimal)data_table4.Rows[0]["Amount"];
                }

                currentSpendingLabel.Text = (last10days / 10).ToString();
            }
            else
            {
                MessageBox.Show("Add a Goal!");
            }


            //UCITAVA ZBIR SVIH TROSENJA

            string get_all_spending_sql = "SELECT SUM(s_amount) AS AllSpending FROM Spendings WHERE s_p_id = " + session.GetId();
            SqlDataAdapter sda2 = new SqlDataAdapter(get_all_spending_sql, connection);

            DataTable data_table2 = new DataTable();
            sda2.Fill(data_table2);

            foreach (DataRow row in data_table2.Rows)
            {
                if (row["AllSpending"] != null && row["AllSpending"] != DBNull.Value)
                {
                    allSpending = (decimal)row["AllSpending"];
                }
            }


            //UCITAVA TROSENJA PODELJENA PO VAZNOSTI

            string get_sorted_spendings_sql = "SELECT SUM(s_amount) AS Amount, s_sbtype_nec AS Necessity FROM Spendings INNER JOIN SpendingSubtypes ON s_s_sbtype_id = s_sbtype_id WHERE s_p_id = " + session.GetId() + " GROUP BY s_sbtype_nec ORDER BY s_sbtype_nec ASC";
            SqlDataAdapter sda3 = new SqlDataAdapter(get_sorted_spendings_sql, connection);

            DataTable data_table3 = new DataTable();
            sda3.Fill(data_table3);

            foreach (DataRow row in data_table3.Rows)
            {
                Int16 x = (Int16)row["Necessity"];
                sortedSpending.Add( x, (decimal)row["Amount"]);
            }

            if (sortedSpending.ContainsKey(1))
            {
                nec1.Text = sortedSpending[1].ToString();
                necBar1.Value = (int)(sortedSpending[1] * 100 / allSpending);
            }
            if (sortedSpending.ContainsKey(2))
            {
                nec2.Text = sortedSpending[2].ToString();
                necBar2.Value = (int)(sortedSpending[2] * 100 / allSpending);
            }
            if (sortedSpending.ContainsKey(3))
            {
                nec3.Text = sortedSpending[3].ToString();
                necBar3.Value = (int)(sortedSpending[3] * 100 / allSpending);
            }
            if (sortedSpending.ContainsKey(4))
            {
                nec4.Text = sortedSpending[4].ToString();
                necBar4.Value = (int)(sortedSpending[4] * 100 / allSpending);
            }
            if (sortedSpending.ContainsKey(5))
            {
                nec5.Text = sortedSpending[5].ToString();
                necBar5.Value = (int)(sortedSpending[5] * 100 / allSpending);
            }
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            Add_Expense add_Expense = new Add_Expense();
            add_Expense.Show();
            this.Hide();
        }

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            Add_Income add_Income = new Add_Income();
            add_Income.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGoal add_Goal = new AddGoal();
            add_Goal.Show();
            this.Hide();
        }

        private void viewIncomeBTN_Click(object sender, EventArgs e)
        {
            ViewIncomeForm viewIncomeForm = new ViewIncomeForm();
            viewIncomeForm.Show();
            this.Hide();
        }

        private void LogOutBTN_Click(object sender, EventArgs e)
        {
            session.ResetSession();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void DeleteGoalsBTN_Click(object sender, EventArgs e)
        {
            Delete_Goal delete_Goal = new Delete_Goal();
            delete_Goal.Show();
            this.Hide();
        }

        private void viewExpensesBTN_Click(object sender, EventArgs e)
        {
            View_Expenses view_Expenses = new View_Expenses();
            view_Expenses.Show();
            this.Hide();
        }

        private void ResetMonthlyIncomeBTN_Click(object sender, EventArgs e)
        {
            Estimated_Income estimated_Income = new Estimated_Income();
            estimated_Income.Show();
            this.Hide();
        }
    }
}

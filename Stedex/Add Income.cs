using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stedex
{
    public partial class Add_Income : Form
    {
        public Add_Income()
        {
            InitializeComponent();
        }

        private void saveExpenseBtn_Click(object sender, EventArgs e)
        {
            Session session = new Session();
            session.AddIncome(aboutTB.Text.Trim(), (decimal)amountBox.Value);
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

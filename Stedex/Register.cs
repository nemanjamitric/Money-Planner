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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string fname, lname, email, pwd, cpwd;

            fname = fnameTB.Text.Trim();
            lname = lnameTB.Text.Trim();
            email = emailTB.Text.Trim();
            pwd = pwdTB.Text.Trim();
            cpwd = cpwdTB.Text.Trim();

            if(pwd == cpwd && fname != "" && lname != "" && email != "" && pwd != "")
            {
                string insert_query = "INSERT INTO Persons (p_fname, p_lname, p_email, p_pwd) VALUES ('" + fname + "', '" + lname + "', '" + email + "', '" + pwd + "')";

                SQLConn sQLConn = new SQLConn();

                SqlConnection connection = new SqlConnection(sQLConn.GetConn());
                SqlCommand cmd = new SqlCommand(insert_query, connection);
                SqlDataReader myReader;
                try
                {
                    connection.Open();
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Saved");
                    while (myReader.Read())
                    {

                    }
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Field left empty or passwords not matching.");
            }



            
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

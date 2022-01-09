using System.Data.SqlClient;
namespace Stedex
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginEmailBox.Text != null && loginPwdBox.Text != null)
            {
                Loginner user = new Loginner(loginEmailBox.Text, loginPwdBox.Text);
                user.TryLogin();
                if (user.TryLogin())
                {
                    Session session = new Session();
                    session.SetSession(loginEmailBox.Text);
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Invalid email or password");
                }
            }
        }

        Register register = new Register();
        private void regBtn_Click(object sender, EventArgs e)
        {
            register.Show();
            this.Hide();
        }

    }
}
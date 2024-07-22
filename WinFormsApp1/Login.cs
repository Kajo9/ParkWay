using ParkWay;
using ParkWay.Models;
using ParkWay.Globalno;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Global.AppName = "ParkWay";

            txtUsername.Text = "mmarkiæ";
            txtPassword.Text = "Password111";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username and password!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Wrong username or password!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var userData = new LoggedUser
                    {
                        UserId = user.ID,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Username = user.Username,
                        Password = user.Password,
                        Role = user.Role
                    };

                    Global.LoggedUser = userData;

                    Hide();
                    Main main = new Main();
                    main.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserAdministration registration = new UserAdministration();
            registration.Show();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}

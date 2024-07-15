using ParkWay;
using ParkWay.Models;

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

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Molimo unesite korisnièko ime i lozinku!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DatabaseContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Pogrešno korisnièko ime ili lozinka!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Hide();
                    Main main = new Main();
                    main.Show();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}

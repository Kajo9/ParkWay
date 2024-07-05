using ParkWay;

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Molimo unesite korisnièke podatke!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Hide();
                Main main = new Main();
                main.Show();
                Close();
            }
        }
    }
}

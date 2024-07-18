using ParkWay.Globalno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkWay
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = Global.LoggedUser.FirstName;
            txtLastName.Text = Global.LoggedUser.LastName;
            txtUsername.Text = Global.LoggedUser.Username;
            txtPassword.Text = Global.LoggedUser.Password;
        }
    }
}

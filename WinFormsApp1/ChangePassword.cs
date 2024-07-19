using ParkWay.Globalno;
using ParkWay.Models;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New Password does not match Confirm Password.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var context = new DatabaseContext())
                {
                    var loggedUser = context.Users.SingleOrDefault(u => u.ID == Global.LoggedUser.UserId);
                    if (loggedUser != null)
                    {
                        loggedUser.Password = newPassword; 

                        context.SaveChanges();
                        MessageBox.Show("Password changed successfully.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while changing the password: {ex.Message}", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

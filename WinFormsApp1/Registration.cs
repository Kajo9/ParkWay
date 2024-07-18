using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkWay.Globalno;
using ParkWay.Models;

namespace ParkWay
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = "User";

            if (ValidateInputs(firstName, lastName, username, password))
            {
                using (var context = new DatabaseContext())
                {

                    if (context.Users.Any(u => u.Username == username ))
                    {
                        MessageBox.Show("Username already exists!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                        var newUser = new User
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Username = username,
                            Password = password,
                            Role = role
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show("User successfully registered!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ResetForm();
                    Close();
                }
            }
        private bool ValidateInputs(string firstname, string lastname, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("Name is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Surname is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("A username is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("A password is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!CheckPasswordStrength(password))
            {
                return false;
            }

            return true;
        }

        private bool CheckPasswordStrength(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Lozinka mora biti barem 8 znakova dugačka", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ParkWay
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            var roles = new List<string> { "Admin", "User" };
            cbRole.DataSource = roles;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtFirsName.Text;
            string lastname = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text; 
            string selectedRole = cbRole.SelectedItem.ToString();

            if (ValidateInputs(firstname,lastname, username, password))
            {
                using (var context = new DatabaseContext())
                {
                    if (selectedRole == "Admin" && context.Users.Any(u => u.Role == "Admin"))
                    {
                        MessageBox.Show("Postoji već osoba s administratorskim ulogama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (context.Users.Any(u => u.Username == username))
                    {
                        MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newUser = new User
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        Username = username,
                        Password = password,
                        Role = selectedRole
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();

                    MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ResetForm()
        {
            txtFirsName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRole.SelectedIndex = 0;
        }

        private bool ValidateInputs(string firstname, string lastname, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("First name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Last name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lozinka mora biti barem 8 znakova dugačka", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

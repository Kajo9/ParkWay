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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ParkWay
{
    public partial class UserAdministration : Form
    {
        public int position = 0;

        public UserAdministration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            var roles = new List<string> { "Admin", "User" };
            cbRole.DataSource = roles;

            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new DatabaseContext())
            {
                var users = context.Users.ToList();

                dgvUsers.DataSource = users;

                dgvUsers.Columns["ID"].Visible = false;
            }
        }

        private void ResetForm()
        {
            position = 0;
            txtPosition.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRole.SelectedIndex = 0;
        }

        private bool ValidateInputs(string firstname, string lastname, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("First name is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Last name is required.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Password must be at least 8 characters long", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = cbRole.SelectedItem.ToString();

            if(!ValidateInputs(firstName, lastName, username, password)) 
            {
                return;
            }

            if (position == 0)
            {
                using (var context = new DatabaseContext())
                {
                    var user = new User
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Username = username,
                        Password = password,
                        Role = selectedRole
                    };

                    context.Users.Add(user);

                    context.SaveChanges();

                    ResetForm();
                    MessageBox.Show("User succesfully adedd!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                using (var context = new DatabaseContext())
                {
                  var user = context.Users.FirstOrDefault(a => a.ID == position);

                    if (user != null)
                    {
                        if (context.Users.Any(a => a.Username == username && a.ID != position))
                        {
                            MessageBox.Show("Username already exists!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Username = username;
                        user.Password = password;
                        user.Role = selectedRole;

                        context.Users.Update(user);

                        context.SaveChanges();

                        ResetForm();
                        MessageBox.Show("User succesfully updated!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            LoadUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (position != 0)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", Global.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var users = context.Users.FirstOrDefault(u => u.ID == position);
                        if (users != null)
                        {
                            context.Users.Remove(users);
                            context.SaveChanges();

                            MessageBox.Show("Data deleted successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadUsers();
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select a row to delete.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Password")
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedIndex = dgvUsers.SelectedRows[0].Index;

                position = int.Parse(dgvUsers.Rows[selectedIndex].Cells["ID"].Value.ToString());
                txtPosition.Text = dgvUsers.Rows[selectedIndex].Cells["ID"].Value.ToString();
                txtFirstName.Text = dgvUsers.Rows[selectedIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[selectedIndex].Cells["LastName"].Value.ToString();
                txtUsername.Text = dgvUsers.Rows[selectedIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[selectedIndex].Cells["Password"].Value.ToString();
                cbRole.SelectedItem = dgvUsers.Rows[selectedIndex].Cells["Role"].Value.ToString();
            }
        }
    }
}

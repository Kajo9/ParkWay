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
        private bool isUpdating = false;

        public UserAdministration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            var roles = new List<string> { "Admin", "User" };
            cbRole.DataSource = roles;

            LoadUsers();
            ResetForm();
        }

        private void LoadUsers()
        {
            using (var context = new DatabaseContext())
            {
                var users = context.Users
                    .Select(u => new
                    {
                        u.ID,
                        u.FirstName,
                        u.LastName,
                        u.Username,
                        u.Password,
                        u.Role
                    })
                    .ToList();

                dgvUsers.DataSource = users;

                dgvUsers.Columns["ID"].Visible = false;

                dgvUsers.ClearSelection();
            }

        }

        private void ResetForm()
        {
            txtFirsName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            dgvUsers.ClearSelection();
        }

        private bool ValidateInputs(string firstname, string lastname, string username, string password)
        {



            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("Ime je obavezno.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Prezime je obavezno.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Potrebno je korisničko ime.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Potrebna je lozinka.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firstName = txtFirsName.Text;
            string lastName = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = cbRole.SelectedItem.ToString();

            if (ValidateInputs(firstName, lastName, username, password))
            {
                using (var context = new DatabaseContext())
                {
                    if (selectedRole == "Admin" && context.Users.Any(u => u.Role == "Admin" && !isUpdating))
                    {
                        MessageBox.Show("Postoji već osoba s administratorskim ulogama", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (context.Users.Any(u => u.Username == username && (!isUpdating || u.ID != (int)dgvUsers.SelectedRows[0].Cells["ID"].Value)))
                    {
                        MessageBox.Show("Korisničko ime već postoji!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (isUpdating)
                    {
                        int selectedUserId = (int)dgvUsers.SelectedRows[0].Cells["ID"].Value;
                        var existingUser = context.Users.FirstOrDefault(u => u.ID == selectedUserId);

                        if (existingUser != null)
                        {
                            existingUser.FirstName = firstName;
                            existingUser.LastName = lastName;
                            existingUser.Username = username;
                            existingUser.Password = password;
                            existingUser.Role = selectedRole;

                            context.SaveChanges();

                            MessageBox.Show("Uspješno ažuriran korisnik!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen korisnik za ažuriranje", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        var newUser = new User
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Username = username,
                            Password = password,
                            Role = selectedRole
                        };

                        context.Users.Add(newUser);
                        context.SaveChanges();

                        MessageBox.Show("Korisnik uspješno registriran!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadUsers();
                    ResetForm();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
                int usersID = (int)dgvUsers.Rows[selectedRowIndex].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", Global.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var users = context.Users.FirstOrDefault(u => u.ID == usersID);
                        if (users != null)
                        {
                            context.Users.Remove(users);
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspešno obrisani!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za brisanje.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati red za brisanje.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                isUpdating = true;
                int selectedRowIndex = dgvUsers.SelectedRows[0].Index;

                txtFirsName.Text = dgvUsers.Rows[selectedRowIndex].Cells["FirstName"].Value.ToString();
                txtLastName.Text = dgvUsers.Rows[selectedRowIndex].Cells["LastName"].Value.ToString();
                txtUsername.Text = dgvUsers.Rows[selectedRowIndex].Cells["Username"].Value.ToString();
                txtPassword.Text = dgvUsers.Rows[selectedRowIndex].Cells["Password"].Value.ToString();
                cbRole.SelectedItem = dgvUsers.Rows[selectedRowIndex].Cells["Role"].Value.ToString();
            }
        }

    }
}

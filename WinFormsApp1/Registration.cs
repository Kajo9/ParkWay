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
        private bool isUpdating = false;

        public Registration()
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
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtFirsName.Text;
            string lastname = txtLastName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string selectedRole = cbRole.SelectedItem.ToString();

            if (ValidateInputs(firstname, lastname, username, password))
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
                    LoadUsers();
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
            dgvUsers.ClearSelection();
        }

        private bool ValidateInputs(string firstname, string lastname, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("Ime je obavezno.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("Prezime je obavezno.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Potrebno je korisničko ime.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Potrebna je lozinka.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isUpdating = false;
            txtFirsName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
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
                        MessageBox.Show("Postoji već osoba s administratorskim ulogama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (context.Users.Any(u => u.Username == username && (!isUpdating || u.ID != (int)dgvUsers.SelectedRows[0].Cells["ID"].Value)))
                    {
                        MessageBox.Show("Korisničko ime već postoji!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            MessageBox.Show("Uspješno ažuriran korisnik!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen korisnik za ažuriranje", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        MessageBox.Show("Korisnik uspješno registriran!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadUsers();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Molimo ispunite sva polja!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvUsers.SelectedRows[0].Index;
                int usersID = (int)dgvUsers.Rows[selectedRowIndex].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var users = context.Users.FirstOrDefault(u => u.ID == usersID);
                        if (users != null)
                        {
                            context.Users.Remove(users);
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspešno obrisani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati red za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

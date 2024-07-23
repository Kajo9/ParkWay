using Microsoft.VisualBasic.ApplicationServices;
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
using WinFormsApp1;

namespace ParkWay
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

            lblLogUser.Text = $"Welcome {Global.LoggedUser.FirstName} {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}";

            //UpdateUIBasedOnRole();
        }

        //private void UpdateUIBasedOnRole()
        //{
        //    if (Global.LoggedUser.Role == "Admin")
        //    {
        //        catalogToolStripMenuItem.Visible = true;
        //        profileToolStripMenuItem.Visible = true;
        //        viewReservationsToolStripMenuItem.Visible = false;
        //        changePasswordToolStripMenuItem.Visible = true;
        //    }
        //    else
        //    {
        //        catalogToolStripMenuItem.Visible = false;
        //        profileToolStripMenuItem.Visible = true;
        //        viewReservationsToolStripMenuItem.Visible = true;
        //        changePasswordToolStripMenuItem.Visible = true;
        //    }
        //}

        private void floorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floor floor = new Floor();
            floor.Show();
        }

        private void parkingSpotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParkingSpot parkingSpot = new ParkingSpot();
            parkingSpot.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdministration registration = new UserAdministration();
            registration.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
        }

        private void viewReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPS reservePS = new ViewPS();
            reservePS.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReserveAdministration reserveAdministration = new ReserveAdministration();
            reserveAdministration.Show();
        }
    }
}

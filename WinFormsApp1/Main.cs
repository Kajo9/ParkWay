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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOverviewofParkingSpaces_Click(object sender, EventArgs e)
        {
            OverviewofParkingSpaces overviewofParkingSpaces = new OverviewofParkingSpaces();
            overviewofParkingSpaces.Show();

            this.Close();
        }

        private void btnAcountOverview_Click(object sender, EventArgs e)
        {
            AccountOverview acountOverview = new AccountOverview();
            acountOverview.Show();

            this.Close();
        }
    }
}

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
    public partial class AccountOverview : Form
    {
        DatabaseContext db = new DatabaseContext();

        public AccountOverview()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Close();
        }

        private void AccountOverview_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = db.Invoices.ToList();
        }
    }
}

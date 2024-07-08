using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParkWay.Models;

namespace ParkWay
{
    public partial class Floor : Form
    {

        DatabaseContext db = new DatabaseContext();
        public Floor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void Floor_Load(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseContext db1 = new DatabaseContext())
                {
                     var nekavarijabla = db1.Floors.ToList();

                }
                
            }
            catch (Exception x)
            {

                var nesto = x;
            }
            
            
            dgvFloors.DataSource = db.Floors.ToList();
                
        }

    }
}

using ParkWay.Globalno;
using ParkWay.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ParkWay
{
    public partial class ReservePS : Form
    {
        public int parkingspotID;

        public ReservePS(int parkingspotID)
        {
            InitializeComponent();
            this.parkingspotID = parkingspotID;
        }

        private void ReservePS_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime futureTime = now.AddHours(1);

            txtFromTime.Text = now.ToString("HH:mm");
            
            txtToTime.Text = futureTime.ToString("HH:mm");
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            TimeSpan fromTime;
            TimeSpan toTime;

            if (!TimeSpan.TryParse(txtFromTime.Text, out fromTime))
            {
                MessageBox.Show("Invalid 'From' time format (e.g., 14:30).", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TimeSpan.TryParse(txtToTime.Text, out toTime))
            {
                MessageBox.Show("Invalid 'To' time format (e.g., 14:30).", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan endtime = new TimeSpan(20, 0, 0);
            if (fromTime > endtime || toTime > endtime)
            {
                MessageBox.Show("Reservations cannot be made for times after 20:00.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fromTime >= toTime)
            {
                MessageBox.Show("To time can't be earlier than or the same as From time!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DatabaseContext())
            {
                DateTime fromDateTime = DateTime.Today.Add(fromTime);
                DateTime toDateTime = DateTime.Today.Add(toTime);

                bool isSpotReserved = context.Reservations.Any(r =>
                    r.ParkingSpotId == parkingspotID &&
                    (
                        (fromDateTime >= r.From && fromDateTime < r.To) ||
                        (toDateTime > r.From && toDateTime <= r.To) ||
                        (fromDateTime < r.From && toDateTime > r.To)
                    )
                );

                if (isSpotReserved)
                {
                    MessageBox.Show("The selected parking spot is already reserved for the specified time period.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var reservation = new Reservation
                {
                    ParkingSpotId = parkingspotID,
                    UserId = Global.LoggedUser.UserId,
                    From = fromDateTime,
                    To = toDateTime,
                    Notice = txtNotice.Text
                };

                context.Reservations.Add(reservation);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Reservation saved successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("An error occurred while saving the reservation:", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

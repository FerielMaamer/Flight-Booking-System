using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPproject_form
{
    public partial class MakeBooking : Form
    {
        private Coordinator coord;
        private int custId;
        private int flightId;
        private string message = "";
        private bool added = false;
        public MakeBooking(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }

        private void addBookingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingList.Text = coord.viewAllFlights()+ coord.viewAllCustomers();
        }

        private void bookingFlightId_TextChanged(object sender, EventArgs e)
        {
            flightId = Convert.ToInt32(bookingFlightId.Text);
        }

        private void bookingCustId_TextChanged(object sender, EventArgs e)
        {
            custId = Convert.ToInt32(bookingCustId.Text);
        }

        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            added = coord.addBooking(custId, flightId);
            message = added ? "successfully added" : "was not able to add";
            addBookingMsg.Text = message;
        }
    }
}

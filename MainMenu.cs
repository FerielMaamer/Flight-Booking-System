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
    public partial class MainMenu : Form
    {
        private FlightManager fm = new FlightManager(100);
        private CustomerManager cm = new CustomerManager(100);
        private BookingManager bm = new BookingManager(100);
        public Coordinator coord;
        public MainMenu()
        {
            InitializeComponent();
            coord = new Coordinator(fm, cm, bm);

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer(coord);
            form.Show();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = coord.viewAllCustomers();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer form = new DeleteCustomer(coord);
            form.Show();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlight form = new AddFlight(coord);
            form.Show();
        }

        private void viewFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text= coord.viewAllFlights();
        }

        private void viewAParticularFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFlight form = new ViewFlight(coord);
            form.Show();
        }

        private void deleteFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFlight form = new DeleteFlight(coord);
            form.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeBooking form = new MakeBooking(coord);
            form.Show();
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = coord.viewAllBookings();
        }
    }
}

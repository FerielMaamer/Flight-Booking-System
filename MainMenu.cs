﻿using System;
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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();

        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomer form = new DeleteCustomer();
            form.Show();
        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFlight form = new AddFlight();
            form.Show();
        }

        private void viewFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAParticularFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFlight form = new ViewFlight();
            form.Show();
        }

        private void deleteFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFlight form = new DeleteFlight();
            form.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeBooking form = new MakeBooking();
            form.Show();
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
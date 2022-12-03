using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace OOPproject_form
{
    public partial class AddFlight : Form
    {
        private Coordinator coord;
        private int flightNumber;
        private string origin;
        private string destination;
        private int capacity;
        private string message = "";
        private bool added = false;
        public AddFlight(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }

        private void flightNumBtn_TextChanged(object sender, EventArgs e)
        {
            flightNumber = Convert.ToInt32(flightNumBtn.Text);
        }

        private void flightOrgBtn_TextChanged(object sender, EventArgs e)
        {
            origin = Convert.ToString(flightOrgBtn.Text);
        }

        private void flightDestBtn_TextChanged(object sender, EventArgs e)
        {
            destination = Convert.ToString(flightDestBtn.Text);
        }

        private void flightCapacityBtn_TextChanged(object sender, EventArgs e)
        {
            capacity=Convert.ToInt32(flightCapacityBtn.Text);
        }

        private void addFlightbtn_Click(object sender, EventArgs e)
        {
            added = coord.addFlight(flightNumber, capacity, origin, destination);
            message = added ? "successfully added" : "was not able to add";
            addFlightMsg.Text = message;

        }
    }
}

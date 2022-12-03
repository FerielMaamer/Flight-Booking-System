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
    public partial class DeleteFlight : Form
    {
        private Coordinator coord;
        private int flightId;
        private string message = "";
        private bool added = false;
        public DeleteFlight(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }

        private void flightIDText_TextChanged(object sender, EventArgs e)
        {
            flightId = Convert.ToInt32(flightIDText.Text);
        }

        private void deleteFlightBtn_Click(object sender, EventArgs e)
        {
            added = coord.deleteFlight(flightId);
            message = added ? "successfully added" : "was not able to add";
            deleteFlightMsg.Text = message;
        }
    }
}

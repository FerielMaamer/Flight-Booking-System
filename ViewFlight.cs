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
    public partial class ViewFlight : Form
    {
        private Coordinator coord;
        private int flightId;
        public ViewFlight(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }
        private void viewFlightId_TextChanged(object sender, EventArgs e)
        {
            flightId = Convert.ToInt32(viewFlightId.Text);
        }
        private void viewFlightBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = coord.viewFlight(flightId);
        }

        
    }
}

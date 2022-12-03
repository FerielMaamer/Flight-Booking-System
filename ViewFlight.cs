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
        public ViewFlight(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }
    }
}

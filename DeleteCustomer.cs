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
    public partial class DeleteCustomer : Form
    {
        private Coordinator coord;
        private int custId;
        private string message = "";
        private bool added = false;
        public DeleteCustomer(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }

        private void custIDText_TextChanged(object sender, EventArgs e)
        {
            custId = Convert.ToInt32(custIDText.Text);
        }

        private void deleteCustBtn_Click(object sender, EventArgs e)
        {
            added = coord.deleteCustomer(custId);
            message = added ? "successfully added" : "was not able to add";
            deleteCustMsg.Text = message;
        }
    }
}

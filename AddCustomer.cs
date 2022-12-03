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
    public partial class AddCustomer : Form
    {
        private Coordinator coord;
        private int id;
        private string fname;
        private string lname;
        private string phoneNum;
        private string message = "";
        private bool added = false;
        public AddCustomer(Coordinator coord)
        {
            InitializeComponent();
            this.coord = coord;
        }

        private void custFNameBtn_TextChanged(object sender, EventArgs e)
        {
            fname = Convert.ToString(custFNameBtn.Text);
        }

        private void custLNameBtn_TextChanged(object sender, EventArgs e)
        {
            lname = Convert.ToString(custLNameBtn.Text);
        }

        private void custPhoneNumBtn_TextChanged(object sender, EventArgs e)
        {
           phoneNum = Convert.ToString(custPhoneNumBtn.Text);
        }

        private void addCustBtn_Click(object sender, EventArgs e)
        {
            added = coord.addCustomer(fname, lname, phoneNum);
            message = added ? "successfully added" : "was not able to add";
            addCustMsg.Text = message;
        }
    }
}

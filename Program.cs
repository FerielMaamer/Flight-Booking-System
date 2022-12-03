using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPproject_form
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //FlightManager fm = new FlightManager(100);
            //CustomerManager cm = new CustomerManager(100);
            //BookingManager bm = new BookingManager(100);
            //Coordinator coord = new Coordinator(fm, cm, bm);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject_form
{
    public class Coordinator
    {
        private FlightManager fm;
        private CustomerManager cm;
        private BookingManager bm;

        public Coordinator(FlightManager flightManager, CustomerManager customerManager, BookingManager bookingManager)
        {
            this.fm = flightManager;
            this.cm = customerManager;
            this.bm = bookingManager;
            fm.loadupdatafromflightsfile();
            cm.loadUpDataFromCustomersFile();
            loadUpDataFromBookingsFile();
        }

        //Flight class functions

        public bool addFlight(int flightNumber, int capacity, string origin, string destination)
        {
            return fm.addFlight(flightNumber, capacity, origin, destination);
        }

        public string viewAllFlights()
        {
            return fm.viewAllFlights();
        }

        public string viewFlight(int flightNumber)
        {
            return fm.viewFlight(flightNumber);
        }
        public bool deleteFlight(int flightNumber)
        {
            return fm.deleteFlight(flightNumber);
        }

        // Customer class functions

        public bool addCustomer(string fname, string lname, string phone)
        {
            return cm.addCustomer(fname, lname, phone);
        }
        public string viewAllCustomers()
        {
            return cm.viewAllCustomers();
        }
        public bool deleteCustomer(int customerNumber)
        {
            return cm.deleteCustomer(customerNumber);
        }

        // Booking class functions


        public bool addBooking(int customerID, int flightID)
        {
            int flightIndex = fm.search(flightID);
            int customerIndex = cm.search(customerID);
            Flight flight = fm.findFlight(flightIndex);
            Customer customer = cm.findCustomer(customerIndex);
            if (flightIndex != -1 && customerIndex != -1 && fm.findFlight(flightIndex).flightHasSpace())
            {
                return bm.addBooking(customer, flight);
            }
            return false;
        }


        private void loadUpDataFromBookingsFile()
        {

            //loop over each line of the file 
            //turn the line into an array 
            //use addCustomers() to add up the data

            // Read file using StreamReader. Reads file line by line   
            try
            {
                string path = @".\\bookings.txt";
                if (File.Exists(path))
                {
                    using (StreamReader file = new StreamReader(path))
                    {

                        string ln;
                        while ((ln = file.ReadLine()) != null)
                        {
                            Console.WriteLine(ln);
                            string[] columns = ln.Split(',');
                            int cutId = int.Parse(columns[0]);
                            int fId = int.Parse(columns[1]);

                            addBooking(cutId, fId);
                        }
                        file.Close();

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



    }

}


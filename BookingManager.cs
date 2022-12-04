using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPproject_form
{
    public class BookingManager
    {
        private Booking[] bookingList;
        private int maxBookings;
        private int numBookings;
        private int bookingSeed;

        public BookingManager(int maxBookings)
        {
            this.maxBookings = maxBookings;
            numBookings = 0;
            bookingList = new Booking[maxBookings];
            bookingSeed = 2000;
            createFile();
            
        }

        public int search(int bookingNumber)
        {
            for (int i = 0; i < bookingList.Length; i++)
            {
                if (bookingList[i] == null) { return -1; }
                if (bookingList[i].getBookingNumber() == bookingNumber)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool addBooking( Customer customer, Flight flight)
        {
            if (numBookings < maxBookings)
            {
                int index = search(bookingSeed);
                if (index == -1)
                {
                    bookingList[numBookings] = new Booking(customer, flight);
                    customer.setNumBookings(1);
                    numBookings++;
                    bookingSeed++;
                    updateBookingsFile();
                    return true;
                }
            }
            return false;
        }

        public string viewBooking(int bookingNumber)
        {
            int index = search(bookingNumber);
            if (index == -1)
            {
                return $"There is no booking with the booking number: {bookingNumber}";
            }
            return bookingList[index].ToString();
        }

        public string viewAllBookings()
        {
            string s = "-------- Bookings --------\n";
            for (int i = 0; i < numBookings; i++)
            {
                s += bookingList[i].ToString() + "\n";
            }
            return s;
        }

        public void createFile()
        {
            string path = @".\\bookings.txt";
            if (!File.Exists(path)) { File.Create(path); }
        }
        public void updateBookingsFile()
        {
            try
            {
                string path = @".\\bookings.txt";
                if (!File.Exists(path)) { File.Create(path); }
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Booking b in bookingList)
                    {
                        if (b != null)
                        {
                            writer.WriteLine("{0},{1}", b.getCustomer().getCustomerID(), b.getFlight().getFlightNumber());
                        }
                        else
                        {
                            break;
                        }
                    }
                    writer.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        
        public void addBookingFromFile(Customer customer,Flight flight)
        {
            bookingList[numBookings] = new Booking(customer, flight);
            numBookings++;
        }

        public void loadUpDataFromBookingsFile(FlightManager fm, CustomerManager cm)
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

                            int flightId = fm.search(fId);
                            int custId = cm.search(cutId);
                            if (flightId != -1 && custId != -1)
                            {

                                bookingList[numBookings] = new Booking(cm.findCustomer(custId), fm.findFlight(flightId));
                                numBookings++;
                            }
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

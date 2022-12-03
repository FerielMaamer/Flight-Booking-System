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
        }

        public int search(int bookingNumber)
        {
            for (int i = 0; i < bookingList.Length; i++)
            {
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

        private void updateBookingsFile()
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
    }
}

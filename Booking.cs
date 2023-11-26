using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class Booking
    {
        private static int bookingCounter = 1;

        public int BookingNumber { get; private set; }
        public int CustomerID { get; set; }
        public int FlightNumber { get; set; }
        public string DateOfBooking { get; set; }

        public Booking(int customerID, int flightNumber, string dateOfBooking)
        {
            BookingNumber = bookingCounter++;
            CustomerID = customerID;
            FlightNumber = flightNumber;
            DateOfBooking = dateOfBooking;
        }

        public override string ToString()
        {
            return $"Booking Number: {BookingNumber}, Customer ID: {CustomerID}, Flight Number: {FlightNumber}, Date of Booking: {DateOfBooking}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    internal class BookingManager
    {
    private List<Booking> availableBookings;
    private List<Booking> deletedBookings;

    public BookingManager()
    {
        availableBookings = new List<Booking>();
        deletedBookings = new List<Booking>();
    }

    public void MakeBooking()
    {
        Console.WriteLine("Enter Customer ID:");
        if (int.TryParse(Console.ReadLine(), out int customerID))
        {
            Console.WriteLine("Enter Flight Number:");
            if (int.TryParse(Console.ReadLine(), out int flightNumber))
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                Booking newBooking = new Booking(customerID, flightNumber, date);
                availableBookings.Add(newBooking);
                Console.WriteLine("Booking successful!");
            }
            else
            {
                Console.WriteLine("Invalid Flight Number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Customer ID.");
        }
    }

    public void DeleteBooking()
    {
        Console.WriteLine("Enter Booking Number to delete:");
        if (int.TryParse(Console.ReadLine(), out int bookingNumber))
        {
            Booking bookingToDelete = availableBookings.Find(booking => booking.BookingNumber == bookingNumber);

            if (bookingToDelete != null)
            {
                availableBookings.Remove(bookingToDelete);
                deletedBookings.Add(bookingToDelete);
                Console.WriteLine("Booking deleted successfully.");
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Booking Number.");
        }
    }

    public void ViewBookings()
    {
        Console.WriteLine("XYZ Airlines Limited - View Bookings");
        Console.WriteLine("Booking Number \t Customer ID \t Flight Number \t Date of Booking");

        foreach (var booking in availableBookings)
        {
            Console.WriteLine($"{booking.BookingNumber} \t\t {booking.CustomerID} \t\t {booking.FlightNumber} \t\t {booking.DateOfBooking}");
        }

        Console.WriteLine("Do you want to view details of a specific booking? (Y/N)");
        if (Console.ReadLine().Trim().ToUpper() == "Y")
        {
            Console.WriteLine("Enter Booking Number:");
            if (int.TryParse(Console.ReadLine(), out int bookingNumber))
            {
                Booking selectedBooking = availableBookings.Find(booking => booking.BookingNumber == bookingNumber);
                if (selectedBooking != null)
                {
                    Console.WriteLine($"Booking Details: {selectedBooking}");
                }
                else
                {
                    Console.WriteLine("Booking not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Booking Number.");
            }
        }
    }

    public void ViewDeletedBookings()
    {
        Console.WriteLine("XYZ Airlines Limited - View Deleted Bookings");
        Console.WriteLine("Booking Number \t Customer ID \t Flight Number \t Date of Booking");

        foreach (var booking in deletedBookings)
        {
            Console.WriteLine($"{booking.BookingNumber} \t\t {booking.CustomerID} \t\t {booking.FlightNumber} \t\t {booking.DateOfBooking}");
        }
    }
}

}

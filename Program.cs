               BookingManager bookingManager = new BookingManager();

                while (true)
                {
                    int userchoice = ShowMainMenu();

                    switch (choice)
                    {
                        case 1:
                            bookingManager.ViewBookings();
                            break;
                        case 2:
                            bookingManager.MakeBooking();
                            break;
                        case 3:
                            bookingManager.DeleteBooking();
                            break;
                        case 4:
                            bookingManager.ViewDeletedBookings();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            static int ShowMainMenu()
            {
                Console.WriteLine("XYZ Airlines Limited");
                Console.WriteLine("Booking Menu");
                Console.WriteLine("Please select a choice from the menu below:");
                Console.WriteLine("1. View Bookings");
                Console.WriteLine("2. Make Booking");
                Console.WriteLine("3. Delete Booking");
                Console.WriteLine("4. View Deleted Bookings");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int userChoice) && userChoice >= 1 && userChoice <= 5)
                {
                    return userChoice;
                }

                Console.WriteLine("Invalid input. Please enter a valid option.");
                return -1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationDesk
{
    public class Reservation
    {
        public DateTime arrivalDate;
        public int numberNights;
        public string roomType;
        public string firstName;
        public string lastName;
        public string guestEmail;
        public string specialNotes;

        public override string ToString()
        {
            string x = "Arrival Date: " + arrivalDate + Environment.NewLine + "Number of Nights: " + numberNights + Environment.NewLine + "Room Type: "
                + roomType + Environment.NewLine + "First Name: " + firstName + Environment.NewLine + "Last Name: " + lastName + Environment.NewLine
                + "Email: " + guestEmail + Environment.NewLine + "Special Notes: " + specialNotes;
            return x;
        }
    }

 
}
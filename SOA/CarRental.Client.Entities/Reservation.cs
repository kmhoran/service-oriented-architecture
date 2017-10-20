using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Client.Entities
{
    class Reservation
    {
        int _ReservationId;
        int _AccountId;
        int _CarId;
        DateTime _RentalDate;
        DateTime _ReturnDate;

        public int ReservationId
        {
            get { return _ReservationId; }
            set { _ReservationId = value; }

        }

        public int AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }

        public int CarId
        {
            get { return _CarId; }
            set { _CarId = value; }
        }

        public DateTime Rental
        {
            get { return _RentalDate; }
            set { _RentalDate = value; }
        }


        public DateTime ReturnDate
        {
            get { return _ReturnDate; }
            set { _ReturnDate = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Client.Entities
{
    class Rental
    {
        int _RentalId;
        int _AccountId;
        int _CarId;
        DateTime _DateRented;
        DateTime _DateDue;
        DateTime? _DateReturned;

        public int RentalId
        {
            get { return _RentalId; }
            set { _RentalId = value; }
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

        public DateTime DateRented
        {
            get { return _DateRented; }
            set { _DateRented = value; }
        }

        public DateTime DateDue
        {
            get { return _DateDue; }
            set { _DateDue = value; }
        }

        public DateTime? DateReturned
        {
            get { return _DateReturned; }
            set { _DateReturned = value; }
        }
    }
}

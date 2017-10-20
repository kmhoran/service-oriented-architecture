using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Client.Entities
{
    class Account
    {
        int _AccountId;
        string _LoginEmail;
        string _FirstName;
        string _LastName;
        string _Address;
        string _City;
        string _State;
        string _ZipCode;
        string _CreditCard;
        string _ExpDate;

        public int AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }

        public string LoginEmail
        {
            get { return _LoginEmail; }
            set { _LoginEmail = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }

        public string CreditCard
        {
            get { return _CreditCard; }
            set { _CreditCard = value; }
        }

        public string ExpDate
        {
            get { return _ExpDate; }
            set { _ExpDate = value; }
        }
    }
}

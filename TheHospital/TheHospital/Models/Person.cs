using System;

namespace TheHospital.Models
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private string _address;
        private string _phoneNumber;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("First name must not be empty.");
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Last name must not be empty.");
                _lastName = value;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value == null) throw new Exception("ID must not be empty.");
                if (value.Length != 13) throw new Exception("ID must contain 13 digits.");
                _id = value;
            }
        }
        public string Address 
        {
            get
            {
                return _address;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("Address must not be empty.");                
                _address = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value == null) throw new Exception("Phone number must not be empty.");
                CheckNumberContainsOnlyDigits(value);

                _phoneNumber = value;
            }
        }

        public Person(string firstName, string lastName, string id, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        private static void CheckNumberContainsOnlyDigits(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c)) throw new Exception("Phone number can contain only digits.");
            }
        }
    }
}

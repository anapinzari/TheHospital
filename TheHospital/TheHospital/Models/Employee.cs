using System;

namespace TheHospital.Models
{
    public class Employee : Person
    {
        private float _salary;

        public float Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0) throw new Exception("Salary must be greater than zero.");
                _salary = value;
            }
        }

        public Employee(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber)
        {
            Salary = salary;
        }
    }
}

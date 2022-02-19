using System;

namespace TheHospital.Models
{
    public class Nurse : Employee
    {
        public Doctor[] Doctors { get; set; }
        public Office[] Offices { get; set; }

        public Nurse(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
        }
    }
}
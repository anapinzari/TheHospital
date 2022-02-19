namespace TheHospital.Models
{
    public class AccountancyDepartment
    {
        public Accountant[] Accountants { get; set; }

        public AccountancyDepartment(Accountant[] accountants)
        {
            Accountants = accountants;
        }
    }

    public class Accountant : Employee
    {
        public Accountant(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
        }
    }
}
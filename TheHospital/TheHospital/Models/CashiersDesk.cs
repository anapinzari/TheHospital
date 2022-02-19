namespace TheHospital.Models
{
    public class CashiersDesk
    {
        public Cashier[] Cashiers { get; set; }

        public CashiersDesk(Cashier[] cashiers)
        {
            Cashiers = cashiers;
        }
    }

    public class Cashier : Employee
    {
        public Cashier(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
        }
    }
}
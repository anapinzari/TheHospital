namespace TheHospital.Models
{
    public class Reception
    {
        public ReceptionManager ReceptionManager { get; set; }
        public Receptionist[] Receptionists { get; set; }

        public Reception(ReceptionManager receptionManager, Receptionist[] receptionists)
        {
            ReceptionManager = receptionManager;
            Receptionists = receptionists;
        }
    }

    public class ReceptionManager : Employee
    {
        public ReceptionManager(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
        }
    }

    public class Receptionist : Employee
    {
        public Receptionist(string firstName, string lastName, string id, string address, string phoneNumber, float salary) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {

        }
    }
}
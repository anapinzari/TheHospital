namespace TheHospital.Models
{
    public class Patient : Person
    {       
        public byte Age { get; set; }

        public bool IsFemale { get; set; }

        public Patient(string firstName, string lastName, string id, string address, string phoneNumber, bool isFemale, byte age) 
            : base(firstName, lastName, id, address, phoneNumber)
        {
            IsFemale = isFemale;
            Age = age;
        }

    }
}
using System;

namespace TheHospital.Models
{
    public class Doctor : Employee
    {
        private int _priceOfConsultation;

        public Specialisation Specialisation { get; set; }
        public Office[] Offices { get; set; }
        public Nurse[] Nurses { get; set; }
        public int PriceOfConsultation
        {
            get
            {
                return _priceOfConsultation;
            }
            set
            {
                if (value < 0) throw new Exception("Price of consultation cannot be negative.");
                _priceOfConsultation = value;
            }
        }

        public Doctor(string firstName, string lastName, string id, string address, string phoneNumber, float salary, 
            Specialisation specialisation, Nurse[] nurses, int priceOfConsultation) 
            : base(firstName, lastName, id, address, phoneNumber, salary)
        {
            Specialisation = specialisation;
            Nurses = nurses;
            PriceOfConsultation = priceOfConsultation;
        }
    }

    public enum Specialisation
    {
        FamilyDoctor,
        Pediatrician,
        SurgeonGeneral,
        AllergistOrImmunologist,
        Anesthesiologist,
        Neurologist,
        ObstetricianAndGynecologist,
        Urologist,
        Dermatologist,
        Ophthalmologist,
        Psychiatrist,
        Pulmonologist,
        Cardiologist,
        Endocrinologist,
        Gastroenterologist,
        Hematologist
    }
}

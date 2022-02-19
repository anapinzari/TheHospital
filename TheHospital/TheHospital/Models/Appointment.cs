using System;

namespace TheHospital.Models
{
    public class Appointment
    {
        public DateTime DateTime { get; set; }
        public Office Office { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Appointment(DateTime dateTime, Office office, Doctor doctor, Patient patient)
        {
            DateTime = dateTime;
            Office = office;
            Doctor = doctor;
            Patient = patient;
        }
    }
}
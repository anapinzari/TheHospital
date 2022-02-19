namespace TheHospital.Models
{
    public class HospitalStructure
    {
        public Doctor[] Doctors { get; set; }
        public Nurse[] Nurses { get; set; }
        public Office[] Offices { get; set; }        
        public Reception Reception { get; set; }
        public CashiersDesk CashiersDesk { get; set; }
        public AccountancyDepartment AccountancyDepartment { get; set; }
        public Appointment[] Appointments { get; set; }

        public HospitalStructure(Doctor[] doctors, Nurse[] nurses, Office[] offices, Reception reception, CashiersDesk cashiersDesk,
            AccountancyDepartment accountancyDepartment, Appointment[] appointments)
        {
            Doctors = doctors;
            Nurses = nurses;
            Offices = offices;
            Reception = reception;
            CashiersDesk = cashiersDesk;
            AccountancyDepartment = accountancyDepartment;
            Appointments = appointments;
        }
    }
}

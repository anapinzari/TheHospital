using System;
using TheHospital.Models;

namespace TheHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Nurse[] nurses = new Nurse[]
            {
                new Nurse("Mariana", "Iapara", "8900237645328", "Chisinau", "079943217", 7900),
                new Nurse("Ionela", "Spataru", "8745320956723", "Chisinau", "067459802", 7900)
            };

            Doctor[] doctors = new Doctor[]
            {
                new Doctor("Eugeniu", "Condrea", "9845398500234", "Chisinau, 4 Milescu Spataru, flat 24", "078653400", 15830, 
                Specialisation.Neurologist, new Nurse[] { nurses[0] }, 450),

                new Doctor("Maria", "Antonescu", "6598235698532", "Chisinau, 23 Independentei, flat 22", "079675404", 12450, 
                Specialisation.FamilyDoctor, new Nurse[] { nurses[1] }, 450)
            };

            #region Add doctors to nurses
            nurses[0].Doctors = new Doctor[] { doctors[0] };
            nurses[1].Doctors = new Doctor[] { doctors[1] };
            #endregion

            Office[] offices = new Office[]
            {
                new Office(OfficeNumber._1, new Doctor[] { doctors[0] }),

                new Office(OfficeNumber._2, new Doctor[] { doctors[1] })
            };

            #region Add offices to doctors
            doctors[0].Offices = new Office[] { offices[0] };
            doctors[1].Offices = new Office[] { offices[1] };
            #endregion

            #region Add offices to nurses
            nurses[0].Offices = new Office[] { offices[0] };
            nurses[1].Offices = new Office[] { offices[1] };
            #endregion

            Reception reception = new Reception(new ReceptionManager("Stiven", "Pinzari", "9845390032276", "Chisinau", "060066599", 9870),
                new Receptionist[] { new Receptionist("Mariana", "Dumbrava", "9007472450945", "Orhei", "078564398", 5400) });

            CashiersDesk cashiersDesk = new CashiersDesk(new Cashier[] { new Cashier("Doinita", "Constantinescu", "6598565380987",
                "Chisinau", "079453211", 6150) });

            AccountancyDepartment accountancyDepartment = new AccountancyDepartment(new Accountant[] { new Accountant("Ion", "Malai", "8745095446509",
                "Chisinau", "061342312", 6900) });

            Appointment[] appointments = new Appointment[]
            {
                new Appointment(new DateTime(2022, 02, 15, 17, 0, 0), offices[0], doctors[0], 
                new Patient("Anastasia", "Lalea", "6754956431298", "Chisinau", "022764533", true, 18))
            };

            HospitalStructure hospital = new HospitalStructure(doctors, nurses, offices, reception, cashiersDesk, accountancyDepartment, appointments);

            Console.ReadKey();
        }
    }
}

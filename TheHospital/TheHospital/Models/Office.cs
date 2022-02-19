using System;

namespace TheHospital.Models
{
    public class Office
    {
        public OfficeNumber OfficeNumber { get; set; }
        public Doctor[] Doctors { get; set; }

        public Office(OfficeNumber officeNumber, Doctor[] doctors)
        {
            OfficeNumber = officeNumber;
            Doctors = doctors;
        }
    }
    public enum OfficeNumber
    {
        _1,
        _2,
        _3,
        _4,
        _5,
        _6,
        _7,
        _8,
        _9,
        _10,
        _11,
        _12,
        _13,
        _14,
        _15,
        _16
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string CodModelo { get; set; }
        public string ModeloComercial { get; set; }
        public double Coste { get; set; }


    }


    public class Student
    {

        private string _firstName;

        public string FirstName
        {
            get
            {
                if (_firstName == "")
                {
                    _firstName = "VALOR_POR_DEFECTO_CUANDO_NO_PONES_NADA";
                }
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string BirthName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZipPostal { get; set; }
        public string Country { get; set; }

    }
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public int ZipPostal { get; set; }
        public string Country { get; set; }
    }
    public class UProgram
    {
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public string Degrees { get; set; }
    }
    public class Degree
    {
        public string DegreeName { get; set; }
        public int CreditsRequired { get; set; }
    }
    public class CourseInformation
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int DurationWeeks { get; set; }
        public string Teacher { get; set; }

    }
    public enum DayWeek {Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
    public enum MonthYear {January,February,March,April,May,June,July,August,September,October,November,December}

}

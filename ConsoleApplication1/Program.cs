using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] estudiantes= new Student[3];
            CourseInformation curso = new CourseInformation();
            Console.Write("Introduzca el titulo del curso...: ");
            curso.CourseName = Console.ReadLine();
            Teacher profe = new Teacher();
            Console.Write("Introduzca el nombre de profesor.: ");
            profe.FirstName = Console.ReadLine();
            curso.Teacher = profe.FirstName;
            Degree grado = new Degree();
            Console.Write("Introduzca el nombre del grado...: ");
            grado.DegreeName = Console.ReadLine();
            UProgram programa = new UProgram();
            Console.Write("Introduzca el nombre del programa: ");
            programa.ProgramName = Console.ReadLine();
            programa.Degrees = grado.DegreeName;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("The {0} program contains the {1} degree", programa.ProgramName, grado.DegreeName);
            Console.WriteLine("");
            Console.WriteLine("The {0} degree contains the course {1}", grado.DegreeName, curso.CourseName );
            Console.WriteLine("");
            Console.WriteLine("The {0} course contains {1} student(s)", curso.CourseName, estudiantes.Length);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
    public class Student
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
}

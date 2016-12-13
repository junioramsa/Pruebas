using Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el nombre, dirección y fecha de nacimiento:");
            var estudiante = new Student()
            {
                FirstName =  Console.ReadLine(),
                AddressLine1 = Console.ReadLine(),
                BirthName = Console.ReadLine()
            };
            Console.WriteLine("Nombre......: {0}",estudiante.FirstName );
            Console.WriteLine("Direccion...: {0}", estudiante.AddressLine1);
            Console.WriteLine("F.Nacimiento: {0}", estudiante.BirthName );
            Console.ReadKey();
        }
    }
}

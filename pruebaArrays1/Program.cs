using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parametros = new string[4];
            for (int i = 0; i < parametros.Length ; i++)
            {
                Console.Write("Introduzca valor del parámetro {0}: ", i);
                parametros[i] = Console.ReadLine();
            }
            for (int i = 0; i < parametros.Length ; i++)
            {
                Console.WriteLine("El parametro numero {0}, tiene el valor: {1}", i, parametros[i]);
                Console.ReadKey();
            }
        }
    }
    
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaArrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numParam;
            Console.WriteLine("");
            Console.Write("Introduzca el numero total de parámetros:");
            numParam = Console.ReadLine();

            int numParameter;
            //tryparse convierte un string en un entero, siempre que pueda.
            int.TryParse(numParam, out numParameter);
            if (numParameter == 0)
            {
                //Al ser una aplicación de consola, si queremos que salga un cuadro de mensaje,
                //debemos agregar una referencia de System.Windows.Forms y añadirla con using.
                MessageBox.Show("Cero parámetros, me salgo.");
                //Console.WriteLine("Cero parámetros, me salgo");
                //Console.ReadLine();
            }

            string[] parametros = new string[numParameter];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string celda="O";
            string linea="";
            for (int filas = 1; filas < 9; filas++)
            {
                for (int columnas = 1; columnas < 9; columnas++)
                {
                    if (celda == "X")
                    {
                        linea += "O";
                        celda = "O";
                    }
                    else
                    {
                        linea += "X";
                        celda = "X";
                    }
                }
                Console.WriteLine(linea);
                linea = "";
                if (celda == "X")
                {
                    celda = "O";
                }
                else
                {
                    celda = "X";
                }
            }
            Console.ReadKey();
        }
    }
}

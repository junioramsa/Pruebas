using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            //cuando defines el array pones el numero total de valores desde uno,
            //cuendo llamas a el valor del array empiezas a numerarlo desde el cero.
            //                                     [0,0][0,1]    [1,0][1,1]    [2,0][2,1]
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            Console.WriteLine(multiArray[1, 1]);
            Console.ReadKey();
        }
    }
}

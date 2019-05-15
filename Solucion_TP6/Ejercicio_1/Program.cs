using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, invertido = 0;

            Console.Write("Ingrese el numero a invertir: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {

                while (num != 0)
                {
                    resto = num % 10;
                    num = num / 10;
                    invertido = invertido * 10 + resto;
                }

                Console.WriteLine("El numero invertido es: " + invertido);
            }
            else
            {
                Console.WriteLine("El numero es menor o igual a 0");
            }
            Console.ReadKey();
        }
    }
}

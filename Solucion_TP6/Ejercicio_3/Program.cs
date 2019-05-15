using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num1, num2;

            Console.Write("Ingrese un numero: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nValor absoluto de " + num + " es: " + Math.Abs(num));

            Console.WriteLine("\nEl cuadrado de " + num + " es: " + Math.Pow(num, 2));

            Console.WriteLine("\nLa raiz cuadrada de " + num + " es: " + Math.Sqrt(num));

            Console.WriteLine("\nEl seno de " + num + " es: " + Math.Sin(num));

            Console.WriteLine("\nEl coseno de " + num + " es: " + Math.Cos(num));

            Console.WriteLine("\nLa parte entera de " + num + " es: " + Math.Truncate(num));

            Console.WriteLine("\n===Maximo y Minimo===");

            Console.WriteLine("\nIngrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIngrese el segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEl maximo entre " + num1 + " y " + num2 + " es: " + Math.Max(num1, num2));

            Console.WriteLine("\nEl minimo entre " + num1 + " y " + num2 + " es: " + Math.Min(num1, num2));

            Console.ReadKey();

        }
    }
}

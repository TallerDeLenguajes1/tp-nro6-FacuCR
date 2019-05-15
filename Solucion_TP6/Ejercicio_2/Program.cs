using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, num1, num2, resul, decision;

            do
            {
                Console.WriteLine(".::Calculadora::.");
                Console.WriteLine("Ingrese una opcion valida:\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir\n");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\n===Suma=== ");

                        Console.Write("\nIngrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nIngrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resul = num1 + num2;
                        Console.WriteLine("\n" + num1 + " + " + num2 + " = " + resul + "\n");

                        Console.WriteLine("Para realizar otra operacion presione 1");
                        decision = Convert.ToInt32(Console.ReadLine());
                        if (decision != 1)
                        {
                            menu = 5;
                        }

                        break;

                    case 2:
                        Console.WriteLine("===Resta===");

                        Console.Write("\nIngrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nIngrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resul = num1 - num2;
                        Console.WriteLine("\n" + num1 + " - " + num2 + " = " + resul + "\n");

                        Console.WriteLine("Para realizar otra operacion presione 1");
                        decision = Convert.ToInt32(Console.ReadLine());
                        if (decision != 1)
                        {
                            menu = 5;
                        }

                        break;

                    case 3:
                        Console.WriteLine("===Multiplicar===");

                        Console.Write("\nIngrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nIngrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resul = num1 * num2;
                        Console.WriteLine("\n" + num1 + " * " + num2 + " = " + resul + "\n");

                        Console.WriteLine("Para realizar otra operacion presione 1");
                        decision = Convert.ToInt32(Console.ReadLine());
                        if (decision != 1)
                        {
                            menu = 5;
                        }

                        break;

                    case 4:
                        Console.WriteLine("===Dividir===");

                        Console.Write("\nIngrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nIngrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resul = num1 / num2;
                        Console.WriteLine("\n" + num1 + " / " + num2 + " = " + resul + "\n");

                        Console.WriteLine("Para realizar otra operacion presione 1");
                        decision = Convert.ToInt32(Console.ReadLine());
                        if (decision != 1)
                        {
                            menu = 5;
                        }

                        break;
                }

            } while (menu != 5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //¿String es una tipo por valor o un tipo por referencia?: String es un tipo de referencia y se comporta como un tipo de valor.
            //¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto? se ignora cualquier cosa en la cadena que normalmente se interpretaría como una secuencia de escape.

            string cad, cad1, cad2, cad3, comparar;
            int num1, num2, resul;

            Console.WriteLine("Ingrese una cadena de caracteres: ");
            cad = Console.ReadLine();

            //Obtener algunas ​letras que forman parte de una cadena 
            for (int i = 0; i < cad.Length; i += 2)
            {
                Console.WriteLine("\n" + cad[i]);
            }

            // Obtener la ​longitud de la cadena y muestre por pantalla
            Console.WriteLine("\n\nLa longitud de la cadena ingresada es: " + cad.Length);

            //Concatenar (Unir) dos cadenas distintas 
            Console.WriteLine("\nIngrese dos cadenas");
            cad1 = Console.ReadLine();
            cad2 = Console.ReadLine();
            Console.WriteLine("Las dos cadenas concatenadas quedan: " + String.Concat(cad1, cad2));

            //Extraer una subcadena
            Console.WriteLine("\n" + cad.Substring(2));

            //Calculadora
            Console.Write("\n===Suma=== ");

            Console.Write("\nIngrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIngrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resul = num1 + num2;
            Console.WriteLine("\nLa suma de " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resul.ToString() + "\n");

            //Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
            string[] nombres = { "Jon", "Ned", "Arya", "Tyrion" };
            foreach(string nombre in nombres)
            {
                Console.WriteLine("\nFOREACH: " + nombre);
            }

            // Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.WriteLine("\nIngrese una cadena para comparar");
            comparar = Console.ReadLine();
            foreach(string nombre in nombres)
            {
                if(comparar.CompareTo(nombre) == 0)
                {
                    Console.WriteLine("\nes igual a la cadena:" + nombre);
                }
                else
                {
                    Console.WriteLine("\n no es igual a la cadena: " + nombre);
                }
            }

            //Convierta la cadena a Mayúsculas y luego  minúsculas
            Console.WriteLine("\nConvertir cadena a mayusculas: " + cad.ToUpper());
            Console.WriteLine("Convertir cadena a minusculas: " + cad.ToLower());

            //Ingrese una nueva cadena y luego compare los valores de ambas
            Console.WriteLine("\nIngrese una nueva cadena para comparar con la primera");
            cad3 = Console.ReadLine();
            if(cad.CompareTo(cad3) == 0)
            {
                Console.WriteLine("Es igual");
            }
            else
            {
                Console.WriteLine("No es igual");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Hacer un programa que solicite la edad del usuario y muestre si es mayor o menor de edad.
 *   Una persona es mayor de edad cuando ya tiene 18 años o más.
 * */

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor ingrese su edad");
            string edad = Console.ReadLine();

            if(int.Parse(edad) >= 18) {
                Console.WriteLine("Felicitaciones! Usted ya es mayor edad");
            } else {
                Console.WriteLine("Todavía no es mayor edad");
            }

            Console.ReadLine();
        }
    }
}

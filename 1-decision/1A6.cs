using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite al usuario dos números y escriba por
 * consola si A es múltiplo de B o B es múltiplo de A.
 * */
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 % numero2 == 0)
            {
                Console.WriteLine("A es múltiplo de B");
            }
            else if (numero2 % numero1 == 0)
            {
                Console.WriteLine("B es múltiplo de A");
            }
            else
            {
                Console.WriteLine("Ninguno es múltiplo de ninguno");
            }

            Console.ReadLine();
        }
    }
}

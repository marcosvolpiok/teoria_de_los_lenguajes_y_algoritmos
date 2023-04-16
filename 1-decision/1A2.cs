using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite al usuario un color y muestre si es primario o no.
 * Los colores primarios son el Rojo, Azul o Amarillo
 * */
namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor ingrese un color primario");

            string color = Console.ReadLine();

            if (color == "rojo" || color == "azul" || color == "amarillo")
            {
                Console.WriteLine("Es primario");
            }
            else
            {
                Console.WriteLine("No Es primario");
            }

            Console.ReadLine();
        }
    }
}

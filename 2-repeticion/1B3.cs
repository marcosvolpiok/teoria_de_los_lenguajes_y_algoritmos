using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite ingreso de un nombre y lo muestre
 * 20 veces de la siguiente manera: “Mi nombre es <ingreso>”.
 * */
namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            for (int i = 0; i < 20; i++ ) {
                Console.WriteLine("Mi nombre es " + nombre);
            }

            Console.ReadLine();
        }
    }
}

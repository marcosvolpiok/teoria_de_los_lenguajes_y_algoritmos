using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que escriba la suma de los 100 primeros
 * números.*/
namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int i = 0; i <= 100; i++ )
            {
                acumulador = acumulador + i;
            }

            Console.WriteLine("La suma de los 100 primeros números es: " + acumulador);
            Console.ReadLine();
        }
    }
}

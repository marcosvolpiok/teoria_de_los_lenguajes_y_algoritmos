using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que permita introducir un número por el usuario y,
 * escriba y cuente los múltiplos de 3 desde la unidad (1) hasta el
 * número ingresado
 * */
namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número natural");
                numeroIngresado = Console.ReadLine();
            } while (!int.TryParse(numeroIngresado, out numeroParseado) || numeroParseado < 1);

            for (int i = 1; i <= numeroParseado; i++)
            {
                Console.WriteLine(i);
                if (i % 3 == 0) {
                    Console.WriteLine("El " + i + " es múltiplo");
                    acumulador++;
                }
            }

            Console.WriteLine("Cantidad total de múltiplos de 3: " + acumulador);
            Console.ReadLine();
        }
    }
}

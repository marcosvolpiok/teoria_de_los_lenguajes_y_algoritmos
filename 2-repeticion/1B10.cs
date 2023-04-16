using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite el ingreso de un número y calcule el factorial.
 * 
 * En matemáticas, el factorial de un número es igual al producto de todos los números enteros positivos desde 1 hasta dicho número.
 * Además, el factorial de un número se representa con un signo de exclamación (!) detrás del número.
 * */

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            bool resultadoValidacionNumero;
            long facturalProductoAcumulado = 1;

            do
            {
                Console.WriteLine("Ingrese un número natural");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
            } while (!resultadoValidacionNumero);

            for (int i = 1; i <= numeroParseado; i++)
            {
                Console.WriteLine(i);
                facturalProductoAcumulado = facturalProductoAcumulado * i;
                Console.WriteLine("acumulado " + facturalProductoAcumulado);
            }

            Console.WriteLine("El factorial del número " + numeroIngresado + " es: " + facturalProductoAcumulado);
            Console.ReadLine();
        }
    }
}

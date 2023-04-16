using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite al usuario el ingreso de un número
 * positivo, no deberá finalizar hasta no tener un ingreso válido.
 * */

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numeroParseado;
            do
            {
                Console.WriteLine("Ingrese un número positivo");
                numeroIngresado = Console.ReadLine();
            } while (!int.TryParse(numeroIngresado, out numeroParseado) || numeroParseado < 0);
        }
    }
}

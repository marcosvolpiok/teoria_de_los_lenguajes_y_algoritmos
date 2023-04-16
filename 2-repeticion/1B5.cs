using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    /*
     * Hacer un programa que escriba todos los números naturales que hay
     * desde la unidad (1) hasta un número ingresado por el usuario.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;

            do {
                Console.WriteLine("Ingrese un número natural");
                numeroIngresado = Console.ReadLine();
            } while (!int.TryParse(numeroIngresado, out numeroParseado) || numeroParseado < 1);
             
            for(int i = 1; i <= numeroParseado; i++) {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

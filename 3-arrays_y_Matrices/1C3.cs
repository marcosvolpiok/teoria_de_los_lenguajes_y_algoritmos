using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que pida el tamaño de un array, y que luego lo
 * complete pero solo permita ingresar números múltiplos de 4.
 * */
namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            bool resultadoValidacionNumero;
            int[] arrayDefinidoPorElUsuario;
            int numeroParseadoArray;

            do
            {
                Console.WriteLine("Ingrese un número positivo");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
            } while (!resultadoValidacionNumero || numeroParseado <= 0);
            arrayDefinidoPorElUsuario = new int[numeroParseado];

            resultadoValidacionNumero = false;
            numeroParseadoArray = numeroParseado;
            numeroParseado = 0;

            for (int i = 0; i < numeroParseadoArray; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un número divisible por 4");
                    numeroIngresado = Console.ReadLine();
                    resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
                } while (!resultadoValidacionNumero || numeroParseado % 4 != 0);

                arrayDefinidoPorElUsuario[i] = numeroParseado;
                Console.WriteLine("Posición " + i + " = " + arrayDefinidoPorElUsuario[i]);
            }

            Console.ReadLine();
        }
    }
}

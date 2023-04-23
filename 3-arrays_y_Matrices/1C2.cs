using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite al usuario el largo del array. Luego, en
 * cada posición del array, guardar la posición al cuadrado.
 * */
namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            bool resultadoValidacionNumero;
            int[] arrayDefinidoPorElUsuario;

            do
            {
                Console.WriteLine("Ingrese un número positivo");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
            } while (!resultadoValidacionNumero || numeroParseado <= 0);
            arrayDefinidoPorElUsuario = new int[numeroParseado];

            for (int i = 0; i < numeroParseado; i++)
            {
                arrayDefinidoPorElUsuario[i] = i * i; 
                Console.WriteLine("posicion " + i + " = " + arrayDefinidoPorElUsuario[i]);
            }

            Console.ReadLine();
        }
    }
}

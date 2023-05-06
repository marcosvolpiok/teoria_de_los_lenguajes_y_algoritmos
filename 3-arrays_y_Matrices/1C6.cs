using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Hacer un programa que cree una matriz de n filas y m columnas
 * (debe solicitar los valores de n y m al usuario), solicite valores al
 * usuario para completarla y muestre los valores de la última fila y de la
 * última columna.
 * */
namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            int numeroParseado1;
            int numeroParseado2;
            string numeroIngresado;
            bool resultadoValidacionNumero;

            do
            {
                Console.WriteLine("Ingrese un número (filas)");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado1);
            } while (!resultadoValidacionNumero);


            do
            {
                Console.WriteLine("Ingrese un número (columnas)");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado2);
            } while (!resultadoValidacionNumero);

            int[,] array = new int[numeroParseado1, numeroParseado2];

            for (int i = 0; i < numeroParseado1; i++)
            {
                for (int j = 0; j < numeroParseado2; j++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese un número");
                        numeroIngresado = Console.ReadLine();
                        resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
                    } while (!resultadoValidacionNumero);

                    array[i, j] = numeroParseado;
                }
            }
            
            //Muestra última fila
            int indexUltimaFila = numeroParseado1 - 1;
            for (int k = 0; k < numeroParseado2; k++ ) {
                Console.WriteLine("Última fila, posición " + k + ": " + array[indexUltimaFila, k]);
            }

            Console.ReadLine();
        }
    }
}

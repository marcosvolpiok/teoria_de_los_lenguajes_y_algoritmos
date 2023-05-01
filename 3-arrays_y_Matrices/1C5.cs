using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que cree una matriz de 3 filas y 4 columnas,
 * solicite números para llenar todas las posiciones y calcule y muestre
 * la suma de todos los elementos guardados.
 * */

namespace ConsoleApplication24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            int numeroParseado;
            string numeroIngresado;
            bool resultadoValidacionNumero;
            int resultadoSumaNumeros = 0;

            for(int i = 0; i<3; i++){
                for (int j = 0; j < 4; j++)
                {
                    do
                    {
                        Console.WriteLine("Ingrese un número");
                        numeroIngresado = Console.ReadLine();
                        resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
                    } while (!resultadoValidacionNumero);

                    array[i, j] = numeroParseado;
                    resultadoSumaNumeros += numeroParseado;
                }
            }

            Console.WriteLine("El resultado de la suma es: " + resultadoSumaNumeros);
            Console.ReadLine();
        }
    }
}

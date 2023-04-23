using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que permita ingresar 20 números enteros, calcule
 * la suma de todos los elementos y la muestre por pantalla.
 * */
namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            bool resultadoValidacionNumero;
            int subTotal = 0;

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un número entero");
                    numeroIngresado = Console.ReadLine();
                    resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
                } while (!resultadoValidacionNumero);
                subTotal = subTotal + numeroParseado;
            }

            Console.WriteLine("El total de números ingresados es: " + subTotal);
            Console.ReadLine();
        }
    }
}

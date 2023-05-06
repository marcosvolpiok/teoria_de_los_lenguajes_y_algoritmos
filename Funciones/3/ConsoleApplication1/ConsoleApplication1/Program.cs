using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer una función que dado un número positivo, muestra si es primo o no.
 * Un número es primo si los divisores son dos, el 1 y el mismo número .
 * */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = pedirNumeroPositivo("Porfavor ingrese un número para saber si es primo o no");

            if(esNumeroPrimo(numero)){
                Console.WriteLine("Es primo");
            }else{
                Console.WriteLine("NO Es primo");
            }

            Console.ReadLine();
        }

        static bool esNumeroPrimo(int numero){
            int numerosPorLosQueEsDivisible = 0;

            for (int i = 2; i <= 9; i++)
            {
                if (numero % i == 0 && numero != i)
                {
                    Console.WriteLine("Es divisible por = " + i);
                    numerosPorLosQueEsDivisible++;
                }
            }

            if(numerosPorLosQueEsDivisible > 0){
                return false;
            }

            return true;
        }

        static int pedirNumeroPositivo(string mensaje)
        {
            int numeroParseado;
            string numeroIngresado;

            do
            {
                Console.WriteLine(mensaje);
                numeroIngresado = Console.ReadLine();
            } while (!int.TryParse(numeroIngresado, out numeroParseado) || numeroParseado < 0);

            return numeroParseado;
        }
    }
}

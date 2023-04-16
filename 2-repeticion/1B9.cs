using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite el ingreso de 5 números y que
 * muestre el mayor y el menor de los ingresados.
 * */

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            int ingresosValidosAcumulados = 0;
            bool resultadoValidacionNumero;
            int[] numeroValidoIngresadoAcumulado = new int[5];
            int mayorNumero = 0;
            int menorNumero = 0;
            bool numerosEstanInicializadas = false;

            do
            {
                Console.WriteLine("Ingrese un número natural");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);

                if (resultadoValidacionNumero)
                {
                    numeroValidoIngresadoAcumulado[ingresosValidosAcumulados] = numeroParseado;
                    ingresosValidosAcumulados++;
                }

            } while (!resultadoValidacionNumero || ingresosValidosAcumulados < 5);

            for(int i = 0; i <= 3; i++) {
                if (numerosEstanInicializadas)
                {
                    numerosEstanInicializadas = true;
                    mayorNumero = numeroValidoIngresadoAcumulado[i];
                    menorNumero = numeroValidoIngresadoAcumulado[i];
                } else {
                    if (numeroValidoIngresadoAcumulado[i] > mayorNumero)
                    {
                        mayorNumero = numeroValidoIngresadoAcumulado[i];
                    }

                    if (numeroValidoIngresadoAcumulado[i] < menorNumero)
                    {
                        menorNumero = numeroValidoIngresadoAcumulado[i];
                    }
                }
            }

            Console.WriteLine("Menor número ingresado: " + menorNumero);
            Console.WriteLine("Mayor número ingresado: " + mayorNumero);

            Console.ReadLine();
        }
    }
}

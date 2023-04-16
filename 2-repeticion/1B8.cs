using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    /*
     * Hacer un programa que permita introducir dos números por el
     * usuario, y escriba todos los números naturales que hay entre ambos
     * números, incluyendolos, empezando por el menor. Además, se pide
     * contar cuántos números hay entre ambos números, cuántos de ellos
     * son pares y la suma de todos los impares. Mostrar los resultados
     * calculados por pantalla.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParseado;
            string numeroIngresado;
            int ingresosValidosAcumulados = 0;
            bool resultadoValidacionNumero;
            int numerosParesIngresados = 0;
            int numerosImparesIngresados = 0;
            int menorNumeroIngresado;
            int mayorNumeroIngresado;
            int[] numeroValidoIngresadoAcumulado = new int[3];
            int totalNumerosEnElRango = 0;


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
                
            } while (!resultadoValidacionNumero || ingresosValidosAcumulados < 2);

            if (numeroValidoIngresadoAcumulado[0] > numeroValidoIngresadoAcumulado[1]) {
                menorNumeroIngresado = numeroValidoIngresadoAcumulado[1];
                mayorNumeroIngresado = numeroValidoIngresadoAcumulado[0];
            } else {
                menorNumeroIngresado = numeroValidoIngresadoAcumulado[0];
                mayorNumeroIngresado = numeroValidoIngresadoAcumulado[1];
            }

            for (int i = menorNumeroIngresado; i <= mayorNumeroIngresado; i++ )
            {
                Console.WriteLine(i);
                totalNumerosEnElRango++;

                if (i % 2 == 0)
                {
                    numerosParesIngresados++;
                } else {
                    numerosImparesIngresados++;
                }
            }


            Console.WriteLine("Cantidad total de números que hay entre el menor y el mayor: " + totalNumerosEnElRango);
            Console.WriteLine("Total de números pares ingresados: " + numerosParesIngresados);
            Console.WriteLine("Total de números impares ingresados: " + numerosImparesIngresados);
            Console.ReadLine();
        }
    }
}

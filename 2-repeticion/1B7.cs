using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    /*
    * Hacer un programa que solicite 20 ingresos al usuario de un número
    * cada vez. Al finalizar, muestre cuántos números pares fueron
    * ingresados.
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

            do
            {
                Console.WriteLine("Ingrese un número natural");
                numeroIngresado = Console.ReadLine();
                resultadoValidacionNumero = int.TryParse(numeroIngresado, out numeroParseado);
                if (resultadoValidacionNumero)
                {
                    if (numeroParseado % 2 == 0) {
                        numerosParesIngresados++;
                    }
                    ingresosValidosAcumulados++;
                }
            } while (!resultadoValidacionNumero || ingresosValidosAcumulados < 20);

            Console.WriteLine("Cantidad total de pares ingresados: " + numerosParesIngresados);
            Console.ReadLine();
        }
    }
}

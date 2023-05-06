using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double denominador = pedirNumeroPositivo("Ingrese el denominador");
            double divisor = pedirNumeroPositivo("Ingrese el divisor");

            double resultadoPaso1 = paso1(denominador, divisor);
            double resultadoPaso2 = paso2(divisor, resultadoPaso1);
            double resultadoPaso3 = paso3(resultadoPaso2);

            Console.WriteLine("El resto es = " + resultadoPaso3);
            Console.ReadLine();
        }


        static double paso1(double denominador, double divisor)
        {
            return denominador / divisor;
        }

        static double paso2(double divisor, double resultadoDivision)
        {
            double resultadoDivisionCon3Decimales = ( (double) ( (int) (resultadoDivision * 1000.0) ) ) / 1000.0 ;
            double resultadoDecimales = resultadoDivisionCon3Decimales - Math.Truncate(resultadoDivisionCon3Decimales);

            return divisor * resultadoDecimales;
        }

        static double paso3(double resultadoPaso2)
        {
            return 1 - resultadoPaso2;
        }


        static int pedirNumeroPositivo(string mensaje)
        {
            int numeroParseado;
            string numeroIngresado;

            do
            {
                Console.WriteLine(mensaje);
                numeroIngresado = Console.ReadLine();
            } while (!int.TryParse(numeroIngresado, out numeroParseado));

            return numeroParseado;
        }
    }
}

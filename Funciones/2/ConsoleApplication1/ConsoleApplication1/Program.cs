using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer una función que multiplique dos números positivos.
 * No se puede utilizar “ * ” en este ejercicio.
 * */
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto1 = pedirNumeroPositivo("Por favor ingrese un número positivo");
            int producto2 = pedirNumeroPositivo("Por favor ingrese otro número positivo");

            int multiplicacionResultado = multiplicarProductos(producto1, producto2);
            Console.WriteLine("Resultado multiplicación = " + multiplicacionResultado);

            Console.ReadLine();
        }

        static int multiplicarProductos(int producto1, int producto2)
        {
            int sumaAcumulada = 0;

            for (int i = 2; i <= producto2; i++)
            {
                sumaAcumulada += producto1 + producto1;
            }

            return sumaAcumulada;
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

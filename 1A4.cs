using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solicite al usuario la cantidad de años de
aportes, edad y género. Luego, analice su edad
Hombres >> 65 años para jubilarse
Mujer >> 60 años para jubilarse
Ambos requieren 30 años de aporte.
 * */


namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pide edad, años de aporte y género
            //Si es hombre y tiene 65 años o más y 30 años o más de porte: ya se puede jubilar
            //Si es mujer y tiene 60 años o más y 30 años o más de porte: ya se puede jubilar


            const int ANIOS_DE_APORTE_MINIMOS = 30;

            Console.WriteLine("Por favor ingrese la cantidad de años aportados");
            int aniosAportados = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese su género");
            string genero = Console.ReadLine();

            if (genero == "hombre" && edad >= 65 && aniosAportados >= 30)
            {
                Console.WriteLine("Usted ya puede jubilarse");
            }
            else if (genero == "mujer" && edad >= 60 && aniosAportados >= 30)
            {
                Console.WriteLine("Usted ya puede jubilarse");
            }
            else
            {
                Console.WriteLine("Usted todavía no puede jubilarse");
            }

            Console.ReadLine();
        }
    }
}

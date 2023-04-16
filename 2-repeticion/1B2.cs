using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Hacer un programa que solo nos permita introducir los valores “S” o
 * “N” en una variable, no deberá finalizar hasta no tener un ingreso
 * válido.
 * */

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionIngresada;

            do {
                Console.WriteLine("Ingrese \"S\" o \"N\"");
                opcionIngresada = Console.ReadLine();
            } while (opcionIngresada != "S" && opcionIngresada != "N");
        }
    }
}

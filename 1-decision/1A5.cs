using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Hacer un programa que solicite al usuario un número y que escriba si
 * es par o impar.
 * */
namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0){
                Console.WriteLine("Es par");
            }else{
                Console.WriteLine("Es impar");
            }

            Console.ReadLine();
        }
    }
}

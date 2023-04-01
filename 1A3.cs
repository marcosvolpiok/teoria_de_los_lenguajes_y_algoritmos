using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 3. Hacer un programa que solicite al usuario la cantidad de años de
 * aportes realizados para la jubilación. Luego, muestre si ya aportó lo
 * suficiente. Si no alcanza, que muestre cuantos años le faltan.
 * Una persona que aporta 30 o más años es suficiente.
 * */
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pide años
            //Si es 30 o más: ya tiene los aportes
            //Si es menos: calcular faltantes

            const int ANIOS_DE_APORTE_MINIMOS = 30;
            Console.WriteLine("Por favor ingrese la cantidad de años aportados");
            int aniosAportados = int.Parse(Console.ReadLine());
            if(aniosAportados >=30){
                Console.WriteLine("Usted ya tiene la cantidad suficiente");
            }else{
                Console.WriteLine("Usted le falta " + (ANIOS_DE_APORTE_MINIMOS - aniosAportados));
            }
            Console.ReadLine();
        }
    }
}

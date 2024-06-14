using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Manzano7b
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Farenheit:");
            int farenheit = Convert.ToInt32(Console.ReadLine());
            double celcius = (farenheit - 32) * (5.0 / 9.0);
            Console.WriteLine("A temperatura de"  + farenheit  + "Convertida para celcius é:" + celcius);
        }
    }
}

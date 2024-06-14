using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Manzano7a
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Digite a temperatura atual:");
            int celcius = Convert.ToInt32(Console.ReadLine());

            int farenheit = (9 * celcius + 160) / 5;
            Console.WriteLine("A temperatura: " + celcius + "Convertido em farenheit é:" + farenheit);
        }
    }
}

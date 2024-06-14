using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class SystemLinq
    {
        public static void Main(string[] args)
        {
            int[] meusNumeros = { 5, 1, 8, 9 };
            Console.WriteLine(meusNumeros.Max());
            Console.WriteLine(meusNumeros.Min());
            Console.WriteLine(meusNumeros.Sum());
        }
    }

}

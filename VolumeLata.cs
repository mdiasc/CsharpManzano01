using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class VolumeLata
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio da lata");
            double  raio = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Digite a altura da Lata");
            double altura = Convert.ToDouble( Console.ReadLine());
            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine("O volume da lata é: " + volume);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fat = 1, x;
            Console.Write("Digite o valor para calcular o fatorial: ");
            n = int.Parse(Console.ReadLine());
            for (x = 1; x <= n; x++)
            {
                fat = fat * x;
            }
            Console.WriteLine("Fatorial: " + fat);
            Console.ReadKey();
        }
    }
}

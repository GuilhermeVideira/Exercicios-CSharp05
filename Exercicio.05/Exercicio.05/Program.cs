using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n, maior = 0;
            for (x = 1; x <= 15; x++)
            {
                Console.Write("Digite um valor: ");
                n = int.Parse(Console.ReadLine());
                if (x == 1 || n > maior)
                {
                    maior = n;
                }
            }
            Console.WriteLine("Maior número: " + maior);
            Console.ReadKey();
        }
    }
}

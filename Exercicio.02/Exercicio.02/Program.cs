using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ini, fim, aux, x;
            Console.Write("Digite o valor inicial: ");
            ini = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            fim = int.Parse(Console.ReadLine());

            if (ini > fim)
            {
                for (x = ini; x >= fim; x--)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            else
            {
                for (x = fim; x >= ini; x--)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine(x);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

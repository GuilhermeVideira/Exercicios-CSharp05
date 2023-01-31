using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
                if (x % 10 == 0)
                {
                    Console.WriteLine("MÚLTIPLO DE 10!");
                }
            }
            Console.ReadKey();
        }
    }
}

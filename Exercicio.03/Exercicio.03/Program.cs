using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, tab;
            Console.Write("Qual tabuada quer ver: ");
            tab = int.Parse(Console.ReadLine());
            for (t = 1; t <= 10; t++)
            {
                Console.WriteLine("{0} x {1} = {2}", tab, t, tab * t);
            }
            Console.ReadKey();
        }
    }
}

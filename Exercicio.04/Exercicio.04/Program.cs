using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ini, fim, aux, x, impar = 0;
            Console.Write("Digite o valor inicial: ");
            ini = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            fim = int.Parse(Console.ReadLine());

            if (ini < fim)
            {
                aux = ini;
                ini = fim;
                fim = aux;
            }
            for (x = ini; x >= fim; x--)
            {
                if (x % 2 != 0)
                {
                    impar++;
                }
            }
            Console.WriteLine("Qtd. números ímpares: " + impar);
            Console.ReadKey();
        }
    }
}

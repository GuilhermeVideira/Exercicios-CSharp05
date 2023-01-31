using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sair;
            int n, par = 0, impar = 0, pos = 0, neg = 0;
            do
            {
                Console.Write("Digite um valor: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                if (n >= 0)
                {
                    pos++;
                }
                else
                {
                    neg++;
                }
                Console.Write("Deseja encerrar o programa <S/N>? ");
                sair = Console.ReadLine().ToUpper();
            } while (sair != "S");
            Console.WriteLine("Qtde. pares=" + par + " ímpares=" + impar + " positivos=" + pos + " negativos=" + neg);
            Console.ReadKey();

        }
    }
}

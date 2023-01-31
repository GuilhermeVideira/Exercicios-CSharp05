using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sair, c;
            double n, e, salario;
            do
            {
                Console.Write("Digite o código do funcionário: ");
                c = Console.ReadLine();
                Console.Write("Digite a qtd. de horas trabalhadas: ");
                n = double.Parse(Console.ReadLine());
                if (n > 50)
                {
                    e = n - 50;
                    salario = 500 + e * 20;
                }
                else
                {
                    e = 0;
                    salario = n * 10;
                }
                Console.WriteLine("Salário total: " + salario);
                Console.WriteLine("Salário excedente: " + (e * 20));
                Console.Write("Deseja encerrar o programa <S/N>? ");
                sair = Console.ReadLine().ToUpper();
            } while (sair != "S");

        }
    }
}

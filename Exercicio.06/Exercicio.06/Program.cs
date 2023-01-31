using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, nota, media = 0;
            for (x = 1; x <= 10; x++)
            {
                Console.Write("Digite uma nota: ");
                nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota inválida!");
                    x--;
                }
                else
                {
                    media = media + nota;
                }
            }
            media = media / 10;
            Console.WriteLine("Média das notas: " + media);
            Console.ReadKey();

        }
    }
}

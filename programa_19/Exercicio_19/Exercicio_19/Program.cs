using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde = 0, contador;

            Console.Write("Digite o valor do intervalo: ");
            qtde = int.Parse(Console.ReadLine());

            if (qtde > 0)
            {
                Console.Write("\n\n");
                for (contador = 1; contador <= qtde; contador++)
                {
                    Console.WriteLine(contador.ToString());
                }
            }
            else
            {
                Console.Write("\n\n");
                Console.WriteLine("O valor não pode ser menor ou igual a ZERO!");
            }

            Console.ReadKey();
        }
    }
    }

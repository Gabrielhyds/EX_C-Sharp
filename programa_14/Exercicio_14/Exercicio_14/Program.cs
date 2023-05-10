using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler dois valores (considere que não serão lidos valores iguais)
            e escrevêlos em ordem crescente.*/

            //Declaração das variáveis do ambiente.
            int vnum1, vnum2;

            Console.Write("Digite um número: ");
            vnum1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite um número: ");
            vnum2 = int.Parse(Console.ReadLine());

            if (vnum1 == vnum2)
            {
                Console.Write("\nERROR: não pode haver dois números iguais, tente novamente!");
            }
            else
            {
                Console.Write("\n\nLista decrescente do número : " + vnum1.ToString());
                for(int cont2 = 0; cont2 <= vnum1; cont2++)
                {
                    Console.Write("\n" +cont2);
                }

                Console.Write("\n\nLista decrescente do número : " + vnum2.ToString());
                for (int cont = 0; cont <= vnum2; cont++)
                {
                    Console.Write("\n" +cont);
                }
            }
            Console.ReadKey();
        }
    }
}
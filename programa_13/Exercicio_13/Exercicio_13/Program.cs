using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*.Ler dois valores (considere que não serão lidos valores iguais) e escrever o
            maior deles.*/

            //declaração de variáveis do ambiente.
            double vnum1, vnum2;

            Console.Write("Informe um número: ");
            vnum1 = double.Parse(Console.ReadLine());

            Console.Write("\nInforme um número: ");
            vnum2 = double.Parse(Console.ReadLine());

            if(vnum1 == vnum2)
            {
                Console.Write("\nERROR: Não pode ser números iguais!");
            }
            else if (vnum1 > vnum2)
            {
                Console.Write("\no Primeiro número digitado é maior que o segundo!");
            }
            else if (vnum1 < vnum2)
            {
                Console.Write("\no segundo número digitado é maior que o primeiro!");
            }
            Console.ReadKey();
        }
    }
}

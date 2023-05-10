using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia,
            e R$ 1,00 se forem compradas pelo menos 12.Escreva um programa que
            leia o número de maçãs compradas, calcule e escreva o custo total da
            compra.*/

            //declarando as variavéis do ambiente.
            double qtdemacas, precocusto = 0;

            Console.Write("Digite a quantidade de maçãs: ");
            qtdemacas = double.Parse(Console.ReadLine());

            if (qtdemacas >= 12)
            {
                precocusto = qtdemacas * 1.00;
            }
            else
            {
                precocusto = qtdemacas * 1.30;
            }

            Console.WriteLine("Valor a pagar é de R$ " + precocusto.ToString());

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma
            mensagem que diga se ela poderá ou não votar este ano (não é necessário
            considerar o mês em que a pessoa nasceu).*/

            //Declarando as variáveis do ambiente.
            double anoAtual, anoNasc;

            Console.Write("Informe o ano em que estamos: ");
            anoAtual = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o ano em que você nasceu: ");
            anoNasc = double.Parse(Console.ReadLine());

            if(anoAtual - anoNasc >= 18)
            {
                Console.Write("\nvocê pode votar!");
            }
            else
            {
                Console.Write("\nvocê não pode votar!");
            }
            Console.ReadKey();

        }
    }
}

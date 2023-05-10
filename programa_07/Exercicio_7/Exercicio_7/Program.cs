using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis do ambiente
            double vendas, salariofixo, comissao, salario;
            int carro;

            Console.Write("Digite o número de carros vendidos: ");
            carro = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor total de suas vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor por carro vendido: ");
            comissao = double.Parse(Console.ReadLine());

            salario = comissao + (comissao * carro) + (vendas * 0.05);
            Console.WriteLine("O salario total do vendedor é : " + salario.ToString());
            Console.ReadKey();

        }
    }
}

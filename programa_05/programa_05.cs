using System;

namespace programa_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para ler o salário mensal atual de um funcionário e o
            percentual de reajuste. Calcular e escrever o valor do novo salário.
            */
            
            //Declarando as variáveis do ambiente.
            double salario,reajuste,desconto,novoSalario;

            //Exibindo mensagem ao usuário do que ele tem que fazer e armazenar o'q ele digitar.
            Console.Write("Digite o valor do salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do reajuste: ");
            reajuste = double.Parse(Console.ReadLine());

            //Calculando o reajuste.
            novoSalario = salario+((salario*reajuste)/100);

            //Apresentando ao usuário o novo salário.
            Console.Write("o novo salario com reajuste é: " +novoSalario.ToString());
        }
    }
}

using System;

namespace programa_02
{
    class Program
    {
        static void Main(string[] args)
        {
              //Escreva um algoritmo para ler as dimensões de um retângulo (base e
            //altura), calcular e escrever a área do retângulo.

            //Declarar as variáveis.
            double area , b , a ;

            /*Apresentar mensagem ao usuário do que ele deve fazer e armazenando
            na variável "b" o valor que ele digitar.*/
            Console.Write("Digite um valor para a base do retângulo: ");
            b = double.Parse(Console.ReadLine());
            
            /*Apresentar mensagem ao usuário do que ele deve fazer e armazenando
            na variável "a" o valor que ele digitar.*/
            Console.Write("\nDigite um valor para a altura do retângulo: ");
            a = double.Parse(Console.ReadLine());

            //Calculando a area do retângulo.
            area = a * b ;

            //apresentando ao usuário o resultado retornado na variável "area";
            Console.Write("\nA area do retângulo é: " +area.ToString());
        }
    }
}

using System;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar as variáveis do ambiente
		double valor , antecessor;
		
		//exibir uma mensagem para o usuário.
		Console.Write("Digite um valor: ");
		valor = double.Parse(Console.ReadLine());
		
		//calcular a formula do antecessor
		antecessor = valor - 1;
		
		//apresentando o resultado para o usuário.
		Console.Write("Antecessor =  " +  antecessor.ToString());
            
        }
    }
}

using System;

namespace programa_04
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Escreva um algoritmo para ler o número total de eleitores de um município,
           o número de votos brancos, nulos e válidos. Calcular e escrever o
           percentual que cada um representa em relação ao total de eleitores.*/

           //declarando as variáveis do ambiente
           double TotalEleitor , VN , VV , VB , VotoBranco , VotoValido , VotoNulo;

           //Exibindo a mensagem ao usuário do que ele tem que fazer
           Console.Write("Digite a quantidade de eleitores: ");
           TotalEleitor = double.Parse(Console.ReadLine());

           Console.Write("Digite a quantidade de votos VALIDOS: ");
           VV = double.Parse(Console.ReadLine());

           Console.Write("Digite a quantidade de votos BRANCOS: ");
           VB = double.Parse(Console.ReadLine());

           Console.Write("Digite a quantidade de votos NULOS: ");
           VN = double.Parse(Console.ReadLine());

           //Realizando o calculo de porcentagem de votos validos, brancos e nulos.
           VotoValido = (100*VV)/TotalEleitor;

           VotoBranco = (100*VB)/TotalEleitor;

           VotoNulo = (100*VN)/TotalEleitor;

           //Apresentando a porcentagem ao usuário.

           Console.Write("\nA quantidade de votos VALIDOS é: " +VotoValido.ToString());
           Console.Write("\n\nA quantidade de votos BRANCOS é: " +VotoBranco.ToString());
           Console.Write("\n\nA quantidade de votos NULOS é: " +VotoNulo.ToString()); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*.Ler as notas da 1a. e 2a. avaliações de um aluno. Calcular a média
            aritmética simples e escrever uma mensagem que diga se o aluno foi ou
            não aprovado(considerar que nota igual ou maior que 6 o aluno é
            aprovado).Escrever também a média calculada.*/

            //declarando as variáveis do ambiente.
            float nota1, nota2, media;            Console.Write("Informe a nota da 1º avaliação: ");            nota1 = float.Parse(Console.ReadLine());            Console.Write("\nInforme a nota da 2º avaliação: ");            nota2 = float.Parse(Console.ReadLine());            media = (nota1 + nota2) / 2;            if(media >= 6)
            {
                Console.Write("\nPARABÉNS , Aluno(a) Aprovado com sucesso!");
            }            else
            {
                Console.Write("\nUMA PENA , Aluno(a) infelizmente foi reprovado!");
            }            Console.WriteLine("\n\nA media do aluno(a) é: " + media.ToString());            Console.ReadKey();
        }
    }
}

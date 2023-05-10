using System;

namespace programa_03
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
            meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
            Considerar ano com 365 dias e mês com 30 dias.*/

            int anos, meses, dias, anos_dias, meses_dias, idade;

            Console.Write("Quantos anos de vida você tem? ");
            anos = int.Parse(Console.ReadLine());

            Console.Write("Quantos meses de vida você tem? ");
            meses = int.Parse(Console.ReadLine());

            Console.Write("Quantos dias de vida você tem? ");
            dias = int.Parse(Console.ReadLine());

            anos_dias = anos * 365;
            meses_dias = meses * 30;
            idade = anos_dias + meses_dias + dias;

            Console.WriteLine("Você tem " + idade.ToString() + " dias de vida!");
            Console.ReadKey();
        }
    }
}

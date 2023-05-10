using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler um valor e escrever se é positivo ou negativo (considere o valor zero
            como positivo).*/

            //Declarando as variáveis do ambiente.
            int vnum;

            //passando a informação para que o usuário possa entender o'q deve fazer
            //e armazenando o numero na variavel "vnum".
            Console.Write("digite um número: ");
            vnum = int.Parse(Console.ReadLine());

            if(vnum >= 0)
            {
                Console.Write("\nO NÚMERO DIGITADO É POSITIVO");
            }
            else
            {
                Console.Write("\nO NÚMERO DIGITADO É NEGATIVO");
            }
            Console.ReadKey();
        }
    }
}

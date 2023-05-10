using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10
            (inclusive) em ordem decrescente.*/

            double vnum = 10;

            Console.Write("O programa apresenta a contagem decrescente do número 10 até 1\n");

            while(vnum >= 1)
            {
                Console.Write("\n" +vnum--);
            }
            Console.ReadKey();
        }
    }
}

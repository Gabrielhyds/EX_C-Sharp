using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo para imprimir os números de 1 (inclusive) a 10
            (inclusive) em ordem crescente.*/
            int vnum = 1;

            Console.Write("programa que apresenta na ordem crescente de 1 até 10.\n");
            while(vnum <= 10)
            {
                Console.Write("\n" +vnum++);
            }
            Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for
            //maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!
            //Declaração das variavéis do ambiente.
            int vnum;

            Console.Write("Digite um valor: ");
            vnum = int.Parse(Console.ReadLine());

            if (vnum > 10)
            {
                Console.Write("É MAIOR QUE 10!");
            }
            else
            {
                Console.Write("É MENOR QUE 10!");
            }
            Console.ReadKey();
        }
    }
}

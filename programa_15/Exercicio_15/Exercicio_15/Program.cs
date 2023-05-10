using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hi, hf, tempo;

            Console.Write("Digite a Hora Inicial: ");
            hi = int.Parse(Console.ReadLine());

            Console.Write("Digite a Hora Final: ");
            hf = int.Parse(Console.ReadLine());

            if (hf < hi)
            {
                tempo = (24 - hi) + hf;
            }
            else
            {
                tempo = hf - hi;
            }

            Console.WriteLine("Tempo de jogo = " + tempo.ToString());
            Console.ReadKey();
        }
    }
}

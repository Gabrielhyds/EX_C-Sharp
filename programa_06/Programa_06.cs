using Internal;
using System;

namespace programa_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variavéis do ambiente
            double vr, rt, adc, imp;  

            Console.Write("Digite o valor de fábrica: ");
			vr = double.Parse(Console.ReadLine());

			adc = vr * (28.0 / 100.0);
			imp = vr * (45.0 / 100.0);
			rt = vr + adc + imp;

			Console.WriteLine("O valor final é " + rt.ToString());
        }
    }
}

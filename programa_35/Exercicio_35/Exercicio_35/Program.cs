using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int tammatriz = 0;
            double soma = 0;

            Console.Write("Digite o tamanho da matriz: ");
            tammatriz = int.Parse(Console.ReadLine());

            if (tammatriz > 0)
            {
                //Definição da matriz quadrada
                double[,] matNumeros = new double[tammatriz, tammatriz];

                //Leitura dos dados da matriz Numeros
                for (int coluna = 0; coluna < tammatriz; coluna++)
                {
                    for (int linha = 0; linha < tammatriz; linha++)
                    {
                        Console.Write("Digite o valor da matNumeros[" + coluna.ToString() + "," + linha.ToString() + "]: ");
                        matNumeros[coluna, linha] = double.Parse(Console.ReadLine());

                        //A
                        //Somando todos os numeros positivos da matriz
                        if (matNumeros[coluna, linha] >= 0)
                        {
                            soma += matNumeros[coluna, linha];
                        }
                    }
                }

                //A
                Console.Write("\n\n");
                Console.WriteLine("Soma dos números positivos da matriz = " + soma.ToString());

                Console.ReadKey();

                //B
                //Digitar qual a linha que será impressa na tela
                Console.Write("\n\n");
                Console.Write("Digite a linha que será impressa: ");
                int numlinha = int.Parse(Console.ReadLine());

                //Exibir as colunas da linha selecionada
                for (int coluna = 0; coluna < tammatriz; coluna++)
                {
                    Console.WriteLine("matNumeros[" + coluna.ToString() + "," + numlinha.ToString() + "] = " + matNumeros[coluna, numlinha].ToString());
                }

                Console.ReadKey();

                //C
                //Digitar qual a coluna que será impressa na tela
                Console.Write("\n\n");
                Console.Write("Digite a coluna que será impressa: ");
                int numcoluna = int.Parse(Console.ReadLine());

                //Exibir as linhas da coluna selecionada
                for (int linha = 0; linha < tammatriz; linha++)
                {
                    Console.WriteLine("matNumeros[" + numcoluna.ToString() + "," + linha.ToString() + "] = " + matNumeros[numcoluna, linha].ToString());
                }

                Console.ReadKey();

                //D
                Console.Write("\n\n");
                //Exibir a diagonal da matriz
                for (int pos = 0; pos < tammatriz; pos++)
                {
                    Console.WriteLine("matNumeros[" + pos.ToString() + "," + pos.ToString() + "] = " + matNumeros[pos, pos].ToString());
                }

                Console.ReadKey();

                //E
                Console.Write("\n\n");
                //Exibir todos os conteudos da matriz
                for (int coluna = 0; coluna < tammatriz; coluna++)
                {
                    for (int linha = 0; linha < tammatriz; linha++)
                    {
                        Console.WriteLine("matNumeros[" + coluna.ToString() + "," + linha.ToString() + "] = " + matNumeros[coluna, linha].ToString());
                    }
                }
            }
            else
            {
                Console.Write("\n\n");
                Console.WriteLine("O tamanho da matriz não pode ser menor ou igual a ZERO!");
            }

            Console.ReadKey();
        }
    }
    }


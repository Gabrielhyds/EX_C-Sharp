using System.Reflection.Emit;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Internal;
using System;

namespace programa_35
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matnumeros = new double[2,2];
            int coluna = 0 , linha = 0;

            //prencher a matriz com números.
            for(linha = 0 ; linha <= 2 ; linha++){
                for(coluna = 0 ; coluna <= 2 ; coluna++){
                    Console.Write("Digite um valor real da matriz[" +ColumnAttribute.ToString() +", "+ linha.ToString());
                    matnumeros[coluna, linha] = int.Parse(Console.ReadLine());
                }
            }
            //exibir a matriz com os numero;
            for(linha = 0 ; linha <= 2 ; linha++){
                for(coluna = 0 ; coluna <= 2 ; coluna++){
                    Console.Write("Digite o")
                }
            }
        }
    }
}

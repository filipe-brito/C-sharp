using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double totalC, totalV, totalL, lucro, lucro1, lucro2, lucro3;

        Console.Write("Serao digitados dados de quantos produtos? ");
        N = int.Parse(Console.ReadLine());

        string[] vetNome = new string[N];
        double[] vetCompra = new double[N];
        double[] vetVenda = new double[N];

        totalC = 0;
        totalV = 0;
        lucro1 = 0;
        lucro2 = 0;
        lucro3 = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.WriteLine("Produto " + (loop+1));
            Console.Write("Nome: ");
            vetNome[loop] = Console.ReadLine();

            Console.Write("Preco de compra: ");
            vetCompra[loop] = double.Parse(Console.ReadLine(), CI);
            totalC = totalC + vetCompra[loop];

            Console.Write("Preco de venda: ");
            vetVenda[loop] = double.Parse(Console.ReadLine(), CI);
            totalV = totalV + vetVenda[loop];

            lucro = (vetVenda[loop] - vetCompra[loop]) * 100 / vetCompra[loop];
            if (lucro < 10)
            {
                lucro1 = lucro1 + 1;
            }
            else if (lucro < 20)
            {
                lucro2 = lucro2 + 1;
            }
            else
            {
                lucro3 = lucro3 + 1;
            }
        }

        Console.WriteLine();

        totalL = totalV - totalC;

        Console.WriteLine("RELATORIO: ");
        Console.WriteLine("Lucro abaixo de 10%: " + (int)lucro1);
        Console.WriteLine("Lucro entre 10% e 20%: " + (int)lucro2);
        Console.WriteLine("Lucro acima de 20%: " + (int)lucro3);
        Console.WriteLine("Valor total de compra: " + totalC.ToString("F2", CI));
        Console.WriteLine("Valor total de venda: " + totalV.ToString("F2", CI));
        Console.WriteLine("Lucro total: " + totalL.ToString("F2", CI));
    }
}
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, quantidade, total, totalC, totalR, totalS;
        char tipo;
        double percC, percR, percS;

        Console.Write("Quantos casos de teste serao digitados? ");
        N = int.Parse(Console.ReadLine());

        totalC = 0;
        totalR = 0;
        totalS = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Quantidade de cobaias: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Tipo de cobaia: ");
            tipo = char.Parse(Console.ReadLine());

            if (tipo == 'c')
            {
                totalC = totalC + quantidade;
            }
            else if (tipo == 'r')
            {
                totalR = totalR + quantidade;
            }
            else if (tipo == 's')
            {
                totalS = totalS + quantidade;
            }
        }

        total = totalC + totalR + totalS;

        percC = (double)totalC * 100 / total;
        percR = (double)totalR * 100 / total;
        percS = (double)totalS * 100 / total;

        Console.WriteLine();

        Console.WriteLine("RELATORIO FINAL:");

        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + totalC);
        Console.WriteLine("Total de ratos: " + totalR);
        Console.WriteLine("Total de sapos: " + totalS);
        Console.WriteLine("Percentual de coelhos: " + percC.ToString("F2", CI));
        Console.WriteLine("Percentual de ratos: " + percR.ToString("F2", CI));
        Console.WriteLine("Percentual de sapos: " + percS.ToString("F2", CI));
    }
}
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, fatorial;

        Console.Write("Digite o valor de N: ");
        N = int.Parse(Console.ReadLine());

        if (N == 0)
        {
            Console.WriteLine("FATORIAL = 1");
        }

        else
        {
            fatorial = N;
            for (int loop = N - 1; loop >= 1; loop--)
            {
                fatorial = fatorial * loop;
            }

            Console.WriteLine("FATORIAL = " + fatorial);
        }

    }
}
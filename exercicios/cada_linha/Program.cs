using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, maior;

        Console.WriteLine("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N,N];

        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]: ");
                mat[loopl,loopc] = int.Parse(Console.ReadLine());
            }
        }


        Console.WriteLine("MAIOR ELEMENTO DE CADA LINHA: ");
        for (int loopl = 0; loopl < N; loopl++)
        {
            maior = 0;
            for (int loopc = 0; loopc < N; loopc++)
            {
                if (mat[loopl,loopc] > maior)
                {
                    maior = mat[loopl,loopc];
                }
            }
            Console.WriteLine(maior);
        }
    }
}
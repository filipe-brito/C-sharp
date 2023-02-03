using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, soma;

        Console.Write("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, N];

        for (int loopl = 0; loopl < N; loopl++)
        {
            for(int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]: ");
                mat[loopl, loopc] = int.Parse(Console.ReadLine());
            }
        }

        soma = 0;
        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = loopl + 1; loopc < N; loopc++)
            {
                soma = soma + mat[loopl, loopc];
            }
        }
        Console.WriteLine("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
    }
}
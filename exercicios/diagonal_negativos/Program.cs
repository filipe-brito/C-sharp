using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, negativos;

        Console.Write("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, N];

        negativos = 0;
        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]: ");
                mat[loopl, loopc] = int.Parse(Console.ReadLine());

                if (mat[loopl, loopc] < 0)
                {
                    negativos++;
                }
            }
        }

        Console.WriteLine("DIAGONAL PRINCIPAL: ");
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write(mat[loop, loop] + "  "); 
        }
        Console.WriteLine();
        Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativos);
    }
}
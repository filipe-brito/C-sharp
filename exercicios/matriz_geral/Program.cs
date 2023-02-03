using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, linha, coluna;
        double soma;

        Console.Write("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        double[,] mat = new double[N, N];

        soma = 0;
        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write("Elemento [" + loopl + "," + loopc + "]: ");
                mat[loopl, loopc] = double.Parse(Console.ReadLine(), CI);

                if (mat[loopl, loopc] > 0)
                {
                    soma = soma + mat[loopl, loopc];
                }
            }
        }
        Console.WriteLine();

        Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CI));
        Console.WriteLine();

        Console.Write("Escolha uma linha: ");
        linha = int.Parse(Console.ReadLine());
        Console.Write("LINHA ESCOLHIDA: " );
        for (int loopl = linha; loopl == linha; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                Console.Write(mat[loopl,loopc].ToString("F1", CI) + "  ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Escolha uma coluna: ");
        coluna = int.Parse(Console.ReadLine());
        Console.Write("COLUNA ESCOLHIDA: ");
        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = coluna; loopc == coluna; loopc++)
            {
                Console.Write(mat[loopl, loopc].ToString("F1", CI) + "  ");
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("DIAGONAL PRINCIPAL: ");
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write(mat[loop,loop].ToString("F1", CI) + "  ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("MATRIZ ALTERADA: ");
        for (int loopl = 0; loopl < N; loopl++)
        {
            for (int loopc = 0; loopc < N; loopc++)
            {
                if (mat[loopl,loopc] < 0)
                {
                    mat[loopl,loopc] = Math.Pow(mat[loopl,loopc], 2);
                    Console.Write(mat[loopl, loopc].ToString("F1", CI) + "  ");
                }
                else
                {
                    Console.Write(mat[loopl, loopc].ToString("F1", CI) + "  ");
                }
            }
            Console.WriteLine();
        }
    }
}
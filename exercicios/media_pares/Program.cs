using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, pares;
        double media;

        Console.Write("Quantos elementos vai ter o vetor? ");
        N = int.Parse(Console.ReadLine());

        int[] vet = new int[N];

        media = 0;
        pares = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Digite um numero: ");
            vet[loop] = int.Parse(Console.ReadLine());
            if (vet[loop] % 2 == 0)
            {
                media = media + vet[loop];
                pares = pares + 1;
            }
        }

        if (pares == 0)
        {
            Console.WriteLine("NENHUM NUMERO PAR");
        }
        else
        {
            media = media / pares;
            Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", CI));
        }
    }
}
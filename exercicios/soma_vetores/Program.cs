using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;

        Console.WriteLine("Quantos valores vai ter cada vetor? ");
        N = int.Parse(Console.ReadLine());

        int[] vetA = new int[N];
        int[] vetB = new int[N];
        int[] vetC = new int[N];

        Console.WriteLine("Digite os valores do vetor A:");
        for (int loop = 0; loop < N; loop++)
        {
            vetA[loop] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite os valores do vetor B:");
        for (int loop = 0; loop < N; loop++)
        {
            vetB[loop] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("VETOR RESULTANTE:");
        for (int loop = 0; loop < N; loop++)
        {
            vetC[loop] = vetA[loop] + vetB[loop];
            Console.WriteLine(vetC[loop]);
        }
    }
}
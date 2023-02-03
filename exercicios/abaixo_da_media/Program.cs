using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double media;

        Console.Write("Quantos elementos vai ter o vetor? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];

        media = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Digite um numero: ");
            vet[loop] = double.Parse(Console.ReadLine(), CI);
            media = media + vet[loop];
        }
        Console.WriteLine();

        media = media / N;

        Console.WriteLine("MEDIA DO VETOR = " + media.ToString("F3", CI));
        Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");
        for (int loop = 0; loop < N; loop++)
        {
            if (vet[loop] < media)
            {
                Console.WriteLine(vet[loop].ToString("F1", CI));
            }
        }
    }
}
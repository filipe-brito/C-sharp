using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double soma, media;

        Console.Write("Quantos numeros voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];

        soma = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Digite um numero: ");
            vet[loop] = double.Parse(Console.ReadLine(), CI);
            soma = soma + vet[loop];
        }
        Console.WriteLine();

        Console.Write("VALORES = ");
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write(vet[loop].ToString("F2", CI) + "  ");
        }

        Console.WriteLine();

        Console.WriteLine("SOMA = " + soma.ToString("F2", CI));

        media = soma / N;
        Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
    }
}
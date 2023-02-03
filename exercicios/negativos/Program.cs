using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;

        Console.Write("Quantos numeros voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];

        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Digite um numero: ");
            vet[loop] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("NUMEROS NEGATIVOS: ");

        for (int loop = 0; loop < N; loop++)
        {
            if (vet[loop] < 0)
            {
                Console.WriteLine(vet[loop]);
            }
        }
    }
}
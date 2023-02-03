using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, posicao;
        double maior;

        Console.Write("Quantos numeros voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];

        posicao = 0;
        maior = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Digite um numero: ");
            vet[loop] = double.Parse(Console.ReadLine(), CI);
            
            if (vet[loop] > maior)
            {
                maior = vet[loop];
                posicao = loop;
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("MAIOR VALOR = " + maior.ToString("F1", CI));
        Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao);
    }
}
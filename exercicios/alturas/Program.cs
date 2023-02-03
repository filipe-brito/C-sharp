using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N, menorI;
        double  somaA, media, perc;

        Console.Write("Quantas pessoas serao digitadas? ");
        N = int.Parse(Console.ReadLine());

        string[] vetNome = new string[N];
        int[] vetIdade = new int[N];
        double[] vetAltura = new double[N];

        somaA = 0;
        menorI = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.WriteLine("Dados da " + (loop + 1) + "a pessoa: ");

            Console.Write("Nome: ");
            vetNome[loop] = Console.ReadLine();

            Console.Write("Idade: ");
            vetIdade[loop] = int.Parse(Console.ReadLine());
            if (vetIdade[loop] < 16)
            {
                menorI = menorI + 1;
            }

            Console.Write("Altura: ");
            vetAltura[loop] = double.Parse(Console.ReadLine(), CI);
            somaA = somaA + vetAltura[loop];
        }
        Console.WriteLine();

        perc = (double)menorI * 100 / N;
        media = (double)somaA / N;

        Console.WriteLine("Altura média: " + media.ToString("F2", CI));
        Console.WriteLine("Pessoas com menos de 16 anos: " + perc.ToString("F2", CI) + "%");
        for (int loop = 0; loop < N; loop++)
        {
            if (vetIdade[loop] < 16)
            {
                Console.WriteLine(vetNome[loop]);
            }
        }
        
    }
}
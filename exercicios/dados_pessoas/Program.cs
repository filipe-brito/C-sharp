using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double maior, menor, mediaM, homens, mulheres;

        Console.Write("Quantas pessoas serao digitadas? ");
        N = int.Parse(Console.ReadLine());

        double[] vetAltura = new double[N];
        char[] vetGenero = new char[N];

        mediaM = 0;
        mulheres = 0;
        homens = 0;
        maior = 0;
        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Altura da " + (loop + 1) + "a pessoa: ");
            vetAltura[loop] = double.Parse(Console.ReadLine(), CI);
            Console.Write("Genero da " + (loop+1) + "a pessoa: ");
            vetGenero[loop] = char.Parse(Console.ReadLine());

            if (vetAltura[loop] > maior)
            {
                maior = vetAltura[loop];
            }

            if (vetGenero[loop] == 'F')
            {
                mediaM = mediaM + vetAltura[loop];
                mulheres = mulheres + 1;
            }
            else
            {
                homens = homens + 1;
            }
        }

        menor = vetAltura[0];
        for(int loop = 0; loop < N; loop++)
        {
            if (vetAltura[loop] < menor)
            {
                menor = vetAltura[loop];
            }
        }

        mediaM = (double)mediaM / mulheres;

        Console.WriteLine("Menor altura = " + menor.ToString("F2", CI));
        Console.WriteLine("Maior altura = " + maior.ToString("F2", CI));
        Console.WriteLine("Media das alturas das mulheres = " + mediaM.ToString("F2", CI));
        Console.WriteLine("Numero de Homens = " + homens);
    }
}
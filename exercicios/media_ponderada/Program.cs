using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double n1, n2, n3, media;

        Console.Write("Quantos casos voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        for (int loop = 0; loop < N; loop++)
        {
            Console.WriteLine("Digite tres numeros: ");
            n1 = double.Parse(Console.ReadLine(), CI);
            n2 = double.Parse(Console.ReadLine(), CI);
            n3 = double.Parse(Console.ReadLine(), CI);

            media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CI));  
        }
    }
}
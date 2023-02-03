using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        int N;
        double numerador, denominador, quociente;

        Console.Write("Quantos casos voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        for (int loop = 0; loop < N; loop++)
        {
            Console.Write("Entre com o numerador: ");
            numerador = double.Parse(Console.ReadLine(), CI);
            Console.Write("Entre com o denominador: ");
            denominador = double.Parse(Console.ReadLine(), CI);

            if (denominador == 0)
            {
                Console.WriteLine("DIVISAO IMPOSSIVEL");
            }
            else
            {
                quociente = numerador / denominador;
                Console.WriteLine("DIVISAO = " + quociente.ToString("F2", CI));
            }
        }
    }
}
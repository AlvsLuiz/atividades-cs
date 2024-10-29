using System;
using Array;
class Exercicio2e3
{
    static double Maior(double[] x)
    {
        double n = x[0];
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] > n)
            {
                n = x[i];
            }
        }
        return n;

    }
    static double Menor(double[] x)
    {
        double n = x[0];
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] < n)
            {
                n = x[i];
            }
        }
        return n;

    }
    static void Main()
    {
        int n;
        Console.WriteLine("qual sera o tamanho do vetor?");
        n = int.Parse(Console.ReadLine());
        double[] x = new double[n];
        BibliotecaArray.GenerateArray(x);
        BibliotecaArray.PrintArray(x);
        double resM = Maior(x);
        Console.WriteLine($"o maior valor eh: {resM:F2}");
        Console.WriteLine($"o menor valor eh: {Menor(x):F2}");

    }
}


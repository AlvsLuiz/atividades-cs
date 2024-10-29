using System;
using Array;
class Exercicio1
{
    static int Soma(int[] x)
    {
        int soma = 0;
        for (int i = 0; i < x.Length; i++)
        {
            soma += x[i];
        }
        return soma;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("qual o tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        Console.WriteLine("Gerado");
        BibliotecaArray.GenerateArray(vet);
        BibliotecaArray.PrintArray(vet);
        Console.WriteLine($"soma do vetor \n{Soma(vet)}");

    }

}

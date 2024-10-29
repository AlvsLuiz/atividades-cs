using System;
using Array;

class Program
{
    static void Main()
    {
        int n, num, cont = 0;
        Console.WriteLine("qual o tamanho do vetor?");
        n = int.Parse(Console.ReadLine());
        int[] vet = new int[n];
        BibliotecaArray.GenerateArray(vet);
        Console.WriteLine("qual o numero a ser verificado?");
        num = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if (vet[i] == num)
            {
                Console.WriteLine($"o numero {num} apareceu na posição {i}");
                cont++;
            }
        }
        Console.WriteLine($"o numero {num} apareceu {cont} vezes!");
    }
}


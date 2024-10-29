using System;
using Array;
class Exercicio6
{
    static void Main()
    {
        int n, teste, cont = 0;
        Console.WriteLine("qual o tamanho do vetor?");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        BibliotecaArray.GenerateArray(vetor);
        Console.WriteLine("digite um numero de 1 a 100 para verificar se este esta no vetor");
        teste = int.Parse(Console.ReadLine());
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == teste)
            {
                Console.WriteLine($"o numero digitado esta na posição {i} do vetor");
                cont++;
            }
        }
        if (cont == 0)
        {
            Console.WriteLine("o numero digitado não esta em nenhuma posição do vetor");

        }
        else
            Console.WriteLine($"o numero digitado apareceu {cont} vezes");
    }
}

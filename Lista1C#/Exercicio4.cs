using System;
using Array;
class Exercicio4
{
    static int Impar(int[] x)
    {
        int quant = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] % 2 == 1)
            {
                quant++;
            }
        }
        return quant;
    }
    static void Main()
    {
        /*Escreva um programa que leia ou gere um vetor de N elementosinteiros. A seguir, crie uma função que receba
        esse vetor e conte quantos valores impares existem no vetor. Retorne a quantidade de impares.*/
        int n;
        n = int.Parse(Console.ReadLine());
        int[] x = new int[n];
        BibliotecaArray.GenerateArray(x);
        BibliotecaArray.PrintArray(x);
        Console.WriteLine($"a quantidade de numeros impares neste vetor eh: {Impar(x)}");
    }
}


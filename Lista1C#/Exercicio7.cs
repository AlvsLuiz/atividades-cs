using System;
using Array;

class Exercicio7
{
    static void Main()
    {
        int n;
        Console.WriteLine("qual o tamanho dos vetores?");
        n = int.Parse(Console.ReadLine());
        int[] x = new int[n], y = new int[n], z = new int[n];
        Console.WriteLine("os parametros do vetor devem ser lidos(l) ou gerados(g)");
        char par;
        par = char.Parse(Console.ReadLine());
        if (char.ToUpper(par) == 'G')
        {
            BibliotecaArray.GenerateArray(y);
            BibliotecaArray.GenerateArray(x);
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("valor de x");
                x[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("valor de y");
                y[i] = int.Parse(Console.ReadLine());
            }

        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"vetor x:|{x[i]}| \nVetor y:|{y[i]}| \n");
            z[i] = x[i] * y[i];
            Console.WriteLine($"resultado de x.y(posicao {i}):|{z[i]}| \n");
        }
    }

}

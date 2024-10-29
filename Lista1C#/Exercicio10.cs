using System;
class Exercicio10
{
    static void Main()
    {
        Console.WriteLine("quantas faces tem o seu dado?");
        int tfac=int.Parse(Console.ReadLine());
        int[] face = new int[tfac];
        Console.WriteLine("quantas vezes sera jogado o dado");
        int n = int.Parse(Console.ReadLine());
        int[] roll = new int[n];
        int ent;
        for (int i = 0; i < tfac; i++)
        {
            face[i] = 0;
        }
        for (int i = 0;i < n; i++)
        {
        ent:
            Console.WriteLine($"qual o valor que caiu na {i + 1}º rodada?");
            ent = int.Parse(Console.ReadLine());
            if (ent>0 && ent < tfac)
            {
                face[ent-1]++;
            }
            else
            {
                Console.WriteLine($"valor invalido, o dado so tem {tfac} faces");
                goto ent;
            }
        }
        for (int i = 0; i < tfac; i++)
        {
            Console.Write($"a face {i+1}");
            Console.WriteLine($" caiu {face[i]} vezes");
        }
    }
}
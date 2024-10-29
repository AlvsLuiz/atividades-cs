using System;
public class Exercicio11
{
    static void Main()
    {
        Console.WriteLine("entre com a frase codificada!");
        string fra = Console.ReadLine();
        Console.WriteLine("frase decodificada");
        for (int i = 1; i < fra.Length; i++)
        {
            if (fra[i] != 'p')
            {
                Console.Write(fra[i]);
            }
            else if (fra[i-1] == 'p' && fra[i+1] == 'p')
            {
                Console.Write(fra[i]);
            }
        }
    }
}

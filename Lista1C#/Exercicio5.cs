using System;
class Exercicio5
{
    static void Main()
    {
        int n;
    n:
        Console.WriteLine("qual o numero de bases? com no maximo 50 bases!");
        n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 51)
        {
            char[] dna = new char[n];
            Console.WriteLine("quais as bases do gene do dna?");
            for (int i = 0; i < dna.Length; i++)
            {
                dna[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Antes");
            for (int i = 0; i < dna.Length; i++)
            {
                Console.Write($"|{dna[i]}|  ");
            }
            Console.Write("\nDepois\n");
            for (int i = 0; i < dna.Length; i++)
            {

                if (char.ToUpper(dna[i]) == 'A')
                {
                    dna[i] = 'T';
                }
                else if (char.ToUpper(dna[i]) == 'T')
                {
                    dna[i] = 'A';
                }
                else if (char.ToUpper(dna[i]) == 'C')
                {
                    dna[i] = 'G';
                }
                else if (char.ToUpper(dna[i]) == 'G')
                {
                    dna[i] = 'C';
                }
                Console.Write($"|{dna[i]}|  ");
            }
        }
        else
            goto n;
    }
}


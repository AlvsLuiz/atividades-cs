using System;
using Array;

class Exercicio8
{
    static void Main()
    {
        string frase;
        Console.WriteLine("entre com a frase desejada");
        frase = Console.ReadLine();
        char[] txt = new char[frase.Length];
        for (int i = 0; i < txt.Length; i++)
        {
            txt[i] = (char)frase[i];
        }
        for (int i = txt.Length - 1; i >= 0; i--)
        {
            Console.Write(txt[i]);
        }
    }
}


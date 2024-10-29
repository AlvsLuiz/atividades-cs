using System;


namespace Array
{
    public class BibliotecaArray
    {
        public static void ReadArray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"[{i}]");
                x[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void ReadArray(double[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"[{i}]");
                x[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void GenerateArray(int[] z)
        {
            Random random = new Random();
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = random.Next(1, 100);
            }
        }
        public static void GenerateArray(double[] z)
        {
            Random random = new Random();
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = random.Next(1, 100);
            }
        }
        public static void PrintArray(int[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
        }
        public static void PrintArray(double[] y)
        {
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
        }

    }
}

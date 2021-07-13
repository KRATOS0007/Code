using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int [n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            int pairs = 0;
            int[] Array = new int[n];
            int Temp = -1;
            for (int i = 0; i < ar.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                        Array[j] = Temp;
                    }
                }
                if (Array[i] != Temp)
                {
                    Array[i] = count;
                }
            }

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] != Temp)
                {
                    int divide = Array[i] / 2;
                    pairs += divide;
                }
            }
            Console.WriteLine(pairs);
        }
    }
}

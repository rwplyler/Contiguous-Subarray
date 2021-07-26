using System;

namespace ContinousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] continous = { 14, 12, 70, 15, 99, 65, 21, 90 };
            int total = 97;
            FindTotal(continous, total);

        }

        static void FindTotal(int[] arr, int X)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int newTotal = arr[i];
                for(int j = i +1; j < arr.Length; j++)
                {
                    newTotal += arr[j];
                    if(newTotal == X)
                    {
                        Console.WriteLine("Sum found between index " + i + " to " + j);
                        Console.Write("The following numbers are ");
                        for(int h = i; h<= j; h++)
                        {
                            if(h == j)
                            {
                                Console.Write("and ");
                            }
                            Console.Write(arr[h] +" ");
                        }
                        return;
                    }
                }
            }
        }
    }
}

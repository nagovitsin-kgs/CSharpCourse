using System;
using System.Collections.Generic;
using System.Linq;

class Program

{
    static void Main(string[] args)
    {
        Console.Write("Write number 1: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = K; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}
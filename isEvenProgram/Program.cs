﻿namespace IsEvenProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine(IsEven(num));
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
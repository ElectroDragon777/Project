using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string>stack = new Stack<string>();
            Console.WriteLine(" == Welcome to the project! ==");
            Console.WriteLine(" - Exercise 1: String mirror using Stack -");
            Console.Write("String to mirror (Use spaces to separate if it is multiple words): ");
            string str1 = Console.ReadLine();
            string[]strArr = str1.Split(' ');
            foreach(var word in strArr)
            {
                stack.Push(word);
            }
            Console.WriteLine("Mirrored string: ");
            foreach(var a in stack)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine("\n - Exercise 2: Number x 5 Pyramid - Recursion -");
            Console.Write("Insert number as a top (it will be multiplied x 5): ");
            int n = int.Parse(Console.ReadLine());
            PyramidNumx5(n,n);
        }
        public static void PyramidNumx5(int n, int staticN)
        {
            if (Math.Abs(n)>staticN)
            {
                return;
            }
            if (Math.Abs(n)==0)
            {
                Console.WriteLine(0);
            }
            Console.WriteLine(Math.Abs(n*5));
            PyramidNumx5(n-1,staticN);
        }
    }
}

using System;

namespace ForLoopForString
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello world";

            for(int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }

            Console.WriteLine();

            for(int i = hello.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(hello[i]);
            }
        }
    }
}

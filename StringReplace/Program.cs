using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello"; //immutable

            //string updatedhello = hello.Replace('e', '3');
            //updatedhello = updatedhello.Replace('o', '0');

            hello = hello.Replace('e', '3');
            hello = hello.Replace('o', '0');

            Console.WriteLine(hello);
            //Console.WriteLine(updatedhello);
        }
    }
}

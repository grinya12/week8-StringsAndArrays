using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameReverse - приложение спрашивает у пользователя его имя и показывает имя задом наперед

            Console.WriteLine("Enter your name: ");

            string Name = Console.ReadLine();
            Console.WriteLine();

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(Name[i]);
            }
        }
    }
}

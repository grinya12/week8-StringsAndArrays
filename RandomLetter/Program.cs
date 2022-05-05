using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandomLetter - приложение спрашивает у пользователя его имя и показывает случайную букву из имени пользователя;

            Random rnd = new Random();
            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            int length = name.Length;

            length = rnd.Next(0, length);

            Console.WriteLine(name[length]);
        }
    }
}

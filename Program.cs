using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Приложение просит пользователя ввести имя и показывает, сколько букв в имени пользователя.

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            int firstNameLength = firstName.Length;

            Console.WriteLine($"Your first name is {firstName.Length} characters long");
        }
    }
}

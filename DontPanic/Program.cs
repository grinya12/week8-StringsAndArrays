using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //DontPanic - приложение заменяет во фразе K33p C4lm все символы '3 на 'e' и все '4' на 'a'

            string K33pC4lm = "K33p C4lm";

            K33pC4lm = K33pC4lm.Replace('3', 'e');
            K33pC4lm = K33pC4lm.Replace('4', 'a');

            Console.WriteLine(K33pC4lm);
        }
    }
}

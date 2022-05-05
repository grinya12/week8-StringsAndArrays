using System;

namespace OCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приложение подсчитывает, сколько раз буква 'о' встречается в строке "hello world"

            int counter = 0;

            string hello = "Ooops, I did it again";

            for(int i = 0; i < hello.Length; i++)
            {
                if(hello[i] == 'o' || hello[i] == 'O')
                {
                    counter++;
                }
            }
            
            Console.WriteLine($"There are {counter} o's in your string.");
        }
    }
}

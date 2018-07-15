using System;

namespace arrayPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valueOne = new string[5];
            

            Console.WriteLine("please enter a number");

            for (int i = 0; i < valueOne.Length; i++)
            {
                valueOne[i] = Console.ReadLine();

                Console.WriteLine("please enter another number");
            }

            for (int i = 0; i < valueOne.Length; i++)
            {
                Console.WriteLine(valueOne[i]);
            }

















            Console.ReadLine();
        }
    }
}

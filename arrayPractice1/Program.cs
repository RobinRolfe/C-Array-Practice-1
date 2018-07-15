using System;

namespace arrayPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valueOne = new string[5]; //declare and initialise the array
            
        
            Console.WriteLine("please enter a number");//promt user for input

            for (int i = 0; i < valueOne.Length; i++)
            {
                valueOne[i] = Console.ReadLine();//assign value

                Console.WriteLine("please enter another number");
            }

            for (int i = 0; i < valueOne.Length; i++)//print the values to the screen
            {
                Console.WriteLine(valueOne[i]);
            }

















            Console.ReadLine();
        }
    }
}

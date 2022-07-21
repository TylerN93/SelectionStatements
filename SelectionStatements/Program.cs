using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            



            Console.WriteLine("Lets play a game");
            
            Console.WriteLine("What it the top number limit");

            var limit = int.Parse(Console.ReadLine());

            var random = new Random();

            var number = random.Next(1, limit);

            Console.WriteLine("Guess a number");

            var guess = int.Parse(Console.ReadLine());



            if (guess <= number)
            { Console.WriteLine("Too Low");
            }

            else if (guess >= number)
            {  Console.WriteLine("Too High"); }

            else
            { Console.WriteLine("Nevermind"); }

            


            


        }
    }
}

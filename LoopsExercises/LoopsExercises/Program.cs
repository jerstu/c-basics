using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Count Numbers 1 to 100 divisible by 3:\n");
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                    count++;
                }
                 
            }
            Console.WriteLine("\nThere are {0} numbers between 1 and 100 divisible by 3.", count);

            ///////////////////////////////////////////////

            Console.WriteLine("\n2: Total user input. \n");

            int total = 0;
            while (true)
            {
                Console.Write("Enter a Number, \"ok\" to exit: ");

                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                total += Convert.ToInt32(input);
            }
            Console.WriteLine("The total of your numbers is {0}.", total);

            ////////////////////////////////////////

            Console.WriteLine("\n3: Factorial. \n");

            Console.Write("Enter a number: ");
            var number = Convert.ToInt64(Console.ReadLine());
            long factorial = 1;
            
            for (var i = number; i > 1; i--)
            {
                Console.Write(i);
                factorial *= i;
                Console.Write(" x ");
            }
            Console.Write("1 = {0}\n", factorial);

            ////////////////////////////////////////////

            Console.WriteLine("\n4: Random numbers.\n");

            var random = new Random();
            var secret = random.Next(1, 10);
            Console.WriteLine(secret);
            Console.WriteLine("Guess number 1 - 10!");
            for (int i = 1; i <= 4 ; i++)
            {
                Console.Write("Guess {0}: ", i);
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else Console.WriteLine("Nope!");

                if (i == 4) Console.WriteLine("You lost :(");
            }

            ///////////////////////////////////////////////////

            Console.WriteLine("\n5: Comma separated series\n");

            Console.WriteLine("Enter numbers separated by commas: ");
            var series = Console.ReadLine();
            var strNums = series.Split(',');

            var max = Convert.ToInt32(strNums[0]);

            foreach (var str in strNums)
            {
                if (Convert.ToInt32(str) > max) max = Convert.ToInt32(str);
            }

            Console.WriteLine(max);








            
            


        }
    }
}

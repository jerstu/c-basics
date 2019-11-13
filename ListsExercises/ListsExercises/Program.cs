using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            CommaList();
            Duplicates();
            FiveNumbers();
            ReverseName();
            Facebook();
        }

        static void Facebook()
        {
            Console.WriteLine("Enter Some Names");
            List<string> Names = new List<string>();
            while (true)
            {
                Console.Write("> ");
                var name = Console.ReadLine();
                if (name.Length == 0) break;
                Names.Add(name);
            }


            switch (Names.Count)
            {
                case 1:
                    Console.WriteLine(Names[0] + " likes your post.");
                    break;
                case 2:
                    Console.WriteLine(Names[0] + " and " + Names[1] + " like your post.");
                    break;
                case 3:
                    Console.WriteLine("{0}, {1} and 1 other person like you post.", Names[0], Names[1]);
                    break;
                case int n when n > 3:
                    Console.WriteLine("{0}, {1} and {2} other people like you post.", Names[0], Names[1], n-2);
                    break;

                default:
                    break;
            }


        }

        static void ReverseName()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            var array = new char[name.Length];

            for (int i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }

            string reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);

        }

        static void FiveNumbers()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter 5 unique numbers.");

            while (numbers.Count < 5)
            {
                Console.Write("> ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Must be unique, retry.");
                    continue;
                }
                numbers.Add(input);
            }

            numbers.Sort();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


        }

        static void Duplicates()
        {
            Console.WriteLine("Enter Numbers or \"Quit\" to exit.");
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }

            List<int> uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }


        }

        static void CommaList()
        {
            var numList = new List<int>();
            Console.WriteLine("Supply a list of comma separated numbers.");
            while (numList.Count < 5)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                var numbers = input.Split(',');
                if (numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List, retry");
                    continue;
                }
                else
                {
                    foreach (var number in numbers)
                    {
                        numList.Add(Convert.ToInt32(number));
                    }
                }
            }
            numList.Sort();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numList[i]);
            }


        }
    }
}

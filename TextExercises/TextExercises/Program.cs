using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Vowels();
            PascalCase();
            Time();
            Duplicates();
            Consecutive();
        }

        static void Consecutive()
        {
            Console.Write("Enter numbers separated by '-'s: ");

            var input = Console.ReadLine().Split('-');
            var numbers = new List<int>();
            foreach (var number in input)            
                numbers.Add(Convert.ToInt32(number));            
            numbers.Sort();
            var consecutive = false;
            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i == numbers.Count)
                {
                    consecutive = true;
                    break;
                }
                if (numbers[i] == numbers[i - 1] + 1)
                    continue;
                else
                    break;                
            }
            var message = consecutive ? "Consecutive" : "Not Consecutive";

            Console.WriteLine(message);
        }

        static void Duplicates()
        {
            Console.Write("Enter numbers separated by '-'s: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var numbers = input.Split('-');
            List<string> numList = new List<string>();
            foreach (string number in numbers)
            {
                if (numList.Contains(number))
                {
                    Console.WriteLine("Duplicates");
                    break;
                }
                else
                    numList.Add(number);
            }

            

        }

        static void Time()
        {
            Console.Write("Enter a time (HH:mm): ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }

            var HHmm = input.Split(':');
            if (HHmm.Length != 2)
            {
                Console.WriteLine("Invalid time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(HHmm[0]);
                var minute = Convert.ToInt32(HHmm[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Valid Time");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
                



        }

        static void PascalCase()
        {
            Console.Write("Input a few words: ");
            var input = Console.ReadLine().Split(' ');
            var pascalString = new StringBuilder();
            foreach (var word in input)
            {
                pascalString.Append(word[0].ToString().ToUpper())
                    .Append(word.Substring(1).ToLower());
            }
            Console.WriteLine(pascalString);
        }

        static void Vowels()
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();
            int vowels = 0;
            foreach (var c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine("Vowels: {0}", vowels);
        }



    }
}

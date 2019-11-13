using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Words();
        }

        static void Words()
        {
            var separators = new char[] { ' ', '.', ',', '!', '?' };
            var file = File.ReadAllText(@"C:\Users\jerst\source\repos\c#basics\FileExercises\FileExercises\readme.txt").Split(separators);
            Console.WriteLine(file.Length);
            int longestWord = 0;
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Length > file[longestWord].Length)
                    longestWord = i;
            }
            Console.WriteLine("Longest Word is {0}.", file[longestWord]);
            
        }
    }
}

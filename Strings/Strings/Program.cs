using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Jeremy";
            var lastName = "Stewart";
            var fullName = firstName + " " + lastName;
            var myName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var listNames = new List<string> { "Jeremy", "Sophia", "Paula" };
            var formattedList = string.Join(", ", listNames);
            Console.WriteLine(formattedList);

            // string with escapes
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            // verbatim string with @
            var verbatimString = 
@"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(verbatimString);

        }
    }
}

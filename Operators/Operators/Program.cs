using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // arithmetic operators
            // + add
            // - subtract
            // * multiply
            // / divide
            // % remainder (modulo)

            // increment operators
            // postfix increment
            //int a = 1;
            //Console.WriteLine(a);
            //int b = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            // value of a assigned to be then a is incremented

            // prefix increment
            //int c = 1;
            //Console.WriteLine(c);
            //int d = ++c;
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            // value of c is incremented then assignd to d

            // Comparison Operators
            // == Equal
            // != Not Equal
            // >  Greater Than
            // >= Greater Than or Equal to
            // <  Less Than
            // <= Less Than or Equal to

            // Assignment operators
            // =    a = 1
            // +=   a += 3      a = a + 3
            // -+   a -= 3      a = a - 3
            // *=   a *= 3      .....
            // /=   a /= 3      .....

            // Logical Operators
            // AND  &&
            // OR   ||
            // NOT  !

            // Bitwise Operators
            // AND  &
            // OR   |

            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);

            // Division
            Console.WriteLine("\ndivision");
            Console.WriteLine(a / 3);
            Console.WriteLine("\nmodulo division (remainder)");
            Console.WriteLine(a % 3);
            Console.WriteLine("\ndivision floating point");
            Console.WriteLine((float)a / (float)3);

            a = 1;
            b = 2;
            var c = 3;

            // operator precedence
            Console.WriteLine("\noperator precedence");
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);

            // comparison operators (boolean)
            Console.WriteLine("\ncomparison operators");
            Console.WriteLine(a > b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a !=b)); // (a == b)

            // logical operators
            Console.WriteLine("\nlogical operators");
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);

        }
    }
}

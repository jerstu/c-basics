using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            int i = 1;
            // cannont implicitly convert int to byte
            // byte b = i;
            // using explicit conversion instead (byte)
            byte b = (byte) i;
            Console.WriteLine(b);

            // conversion method for incompatible types
            string number = "1234";
            i = Convert.ToInt32(number);
            Console.WriteLine(i);


            try
            {
                byte Byte = Convert.ToByte(number);
                Console.WriteLine(Byte);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool Bool = Convert.ToBoolean(str);
                Console.WriteLine(Bool);
            }
            catch (Exception)
            {

                throw;
            }
            
                




        }
    }
}

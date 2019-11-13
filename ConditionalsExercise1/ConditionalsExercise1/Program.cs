using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a number. 
            //    The number should be between 1 to 10.
            //    If the user enters a valid number, 
            //    display "Valid" on the console.
            //    Otherwise, display "Invalid". 
            //    (This logic is used a lot in applications
            //    where values entered into input boxes need to be validated.)
            Console.WriteLine("Exercise 1: validate input\n");

            Console.Write("Enter a number 1 to 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            // 2 - Write a program which takes two numbers from the console 
            // and displays the maximum of the two.     
            Console.WriteLine("\nExercise 2: display max\n");

            Console.Write("Input a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine(number1);
            else if (number1 < number2)
                Console.WriteLine(number2);
            else if (number1 == number2)
                Console.WriteLine("equal");

            // 3 - Write a program and ask the user to enter the 
            // width and height of an image. Then tell if the image
            // is landscape or portrait.
            Console.WriteLine("\nExercise 3 portrait or landscape\n");
            Console.Write("Width: ");
            var width = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Height: ");
            var height = Convert.ToDecimal(Console.ReadLine());

            if (width / height < 1)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Landscape");

            // 4 - Your job is to write a program for a speed camera.
            // For simplicity, ignore the details such as camera, sensors, etc
            // and focus purely on the logic.Write a program that asks the 
            // user to enter the speed limit.Once set, the program asks for 
            // the speed of a car.If the user enters a value less than the 
            // speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should 
            // calculate the number of demerit points.For every 5km / hr above
            // the speed limit, 1 demerit points should be incurred and displayed 
            // on the console.If the number of demerit points is above 12,
            // the program should display License Suspended.

            Console.WriteLine("\nExercise 4 Speeding Camera\n");

            Console.WriteLine("Speed Limit: ");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Car Speed: ");
            int CarSpeed = Convert.ToInt32(Console.ReadLine());

            if (CarSpeed <= SpeedLimit)
            {
                Console.WriteLine("Okay.");
            }
            else
            {
                var Demerits = (CarSpeed - SpeedLimit) / 5;
                Console.WriteLine("Demerits: {0}", Demerits);
                if (Demerits > 12) Console.WriteLine("License Suspended!");
            }

            Console.ReadLine();


        }
    }
}

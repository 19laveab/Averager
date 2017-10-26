using System;

namespace Averager
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalNumber = 0.0;
            int divideNum = 0;

            //loop continues until the break
            while (true)
            {
                //Ask for the Number
                Console.Write("Enter a number or type \"done\" to see the average: ");

                //Number request
                var number = Console.ReadLine();
                
                //Close the program and tell the total
                if (number.ToLower() == "done")
                {
                    Console.WriteLine("Your total number is " + totalNumber + ".");

                    break;
                }

                //set of double intergers and adding numbers entered
                try
                {
                    var realnumber = double.Parse(number);

                    divideNum += 1;

                    totalNumber += realnumber;

                    totalNumber = totalNumber / divideNum;
                }

                //tell the error about not using the numbers
                catch (FormatException)
                {
                    Console.WriteLine("That's is not valid input.");
                    continue;
                }

            }
        }
    }
}
using System;

namespace CG3_1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            //Prompt the user for the number of a month.
            Console.WriteLine("Please enter 1 through 12 for the month");
            //Get the number from the console and spell out the name of the month.
            string userValue = Console.ReadLine();

            string message = "";
            //Use the if, else to identify which month to spell out on the console.
            if (userValue == "1")
                message = "You input a 1 which is January";
            else if (userValue == "2")
                message = "You input a 2 which is February";
            else if (userValue == "3")
                message = "You input a 3 which is March";
            else if (userValue == "4")
                message = "You input a 4 which is April";
            else if (userValue == "5")
                message = "You input a 5 which is May";
            else if (userValue == "6")
                message = "You input a 6 which is June";
            else if (userValue == "7")
                message = "You input a 7 which is July";
            else if (userValue == "8")
                message = "You input a 8 which is August";
            else if (userValue == "9")
                message = "You input a 9 which is September";
            else if (userValue == "10")
                message = "You input a 10 which is October";
            else if (userValue == "11")
                message = "You input a 11 which is November";
            else if (userValue == "12")
                message = "You input a 12 which is December";
            else

            //Write an error message to the console if the user inputs any number other than 1 through 12.
            {
                message = "Sorry that is an invalid date.";
            }
            
            Console.WriteLine(message);
            Console.ReadLine();
           




        }
    }
}

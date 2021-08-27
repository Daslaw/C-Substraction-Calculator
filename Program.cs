using System;

namespace subtraction2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of Values
            int firstNumber = 0;
            int secondNumber = 0;
            int subResult= 0;

            // Request for values from the respondent
            Console.WriteLine("Enter your first Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

           // Subtraction and Displays of Result
            subResult = firstNumber - secondNumber;  
            Console.WriteLine ("The result : "+ subResult);
        }
    }
}
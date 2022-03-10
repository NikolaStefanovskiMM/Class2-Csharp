using System;

namespace Class2_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int variabOne = 1;
            int variabTwo = 2;
            int result = variabOne + variabTwo;
            Console.WriteLine(result);
            Console.WriteLine(variabOne + variabTwo);

            decimal decimalVariableOne = 1.5m;
            decimal decimalVariableTwo = 2.5m;

            decimal decimalResult = decimalVariableTwo - decimalVariableOne;
            decimal decimalResultMultiplication = decimalVariableOne * decimalVariableTwo;
            Console.WriteLine(decimalResultMultiplication);
            Console.WriteLine(decimalResult);

            bool boolVariableOne = true;
            bool boolVariableTwo = false;

            bool boolResult = boolVariableOne && boolVariableTwo; //false
            bool boolResult2 = boolVariableOne || boolVariableTwo;
            bool boolResult3 = !(boolVariableOne) || boolVariableTwo;

            Console.WriteLine(boolResult);
            Console.WriteLine(boolResult2);
            Console.WriteLine(boolResult3);

            //Exercise 1:

            int num1 = 10;
            int num2 = 100;
            int resultDevide = num2 / num1;
            Console.WriteLine(resultDevide);

            double num3 = 153.25;
            double num4 = 252.351;
            double doubleResult = num4 / num3;
            Console.WriteLine(doubleResult);
            Console.WriteLine(num3 * num4);

            //Exercise 2:

            string fName = "Nikola";
            string lName = "Stefanovski";
            Console.WriteLine(fName + " " + lName);

            string stringOne = "3";
            string stringTwo = "9";
            string stringResult = stringOne + stringTwo;
            Console.WriteLine(stringResult);

            //Practise 1:

            Console.WriteLine("Enter a number...");
            string number = Console.ReadLine();
            Console.WriteLine(number);

            //Exercise 3:

            Console.WriteLine("Enter your credit status:");
            string credit = Console.ReadLine();
            int parseCredit = int.Parse(credit);
            
            Console.WriteLine("Enter cost of one message");
            string smsCost = Console.ReadLine();
            int parseSms = int.Parse(smsCost);

            double resultTest = parseCredit / parseSms;
            Console.WriteLine(resultTest);
            Console.WriteLine("From your credit status: " + parseCredit + "$ and your price for one massage is: " + parseSms + "$ you can sent: " + resultTest + " sms.");

            //Practise 2:

            Console.WriteLine("Enter two numbers:");
            string firstNumString = Console.ReadLine();
            string secondNumString = Console.ReadLine();

            int firstNum = int.Parse(firstNumString);
            int secondNum = int.Parse(secondNumString);

            if(firstNum > secondNum)
            {
                Console.WriteLine("First number is bigger!");
            }
            else
            {
                Console.WriteLine("Second number is bigger!");
            }


        }
    }
}

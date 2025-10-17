using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("What type of problem do you want to do? To add enter a +. To subtract enter a -. To multiply enter an *. To divide with decimals enter a /. If you want to divide without decimals, enter //.  To find a remainder enter a %. If you and to do an exponent, type ^. If you would like to do fractions, enter x/x");
            String equationType = Console.ReadLine();
            if (equationType == "x/x") 
            {
                Console.WriteLine("Please enter first Numerator.");
                String numerator1 = Console.ReadLine();
                Console.WriteLine("Please enter first denominator.");
                String denominator1 = Console.ReadLine();
                Console.WriteLine("Please enter second Numerator.");
                String numerator2 = Console.ReadLine();
                Console.WriteLine("Please enter second denominator.");
                String denominator2 = Console.ReadLine();
            }
            else if (equationType == "+")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (number1 + number2) + ".");
            }
            else if (equationType == "-")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (number1 - number2) + ".");
            }
            else if (equationType == "*")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (number1 * number2) + ".");
            }
            else if (equationType == "/")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (number1 / number2) + ".");
            }
            else if (equationType == "//")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (numb1 / numb2) + ".");
            }
            else if (equationType == "%")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + (number1 % number2) + ".");
            }
            else if (equationType == "^")
            {
                Console.WriteLine("Insert first number:");
                String num1 = Console.ReadLine();
                int numb1 = int.Parse(num1);
                double number1 = double.Parse(num1);
                Console.WriteLine("Insert second number:");
                String num2 = Console.ReadLine();
                int numb2 = int.Parse(num2);
                double number2 = double.Parse(num2);
                Console.Clear();
                Console.WriteLine("Your answer is: " + Math.Pow(number1, number2) + ".");
            }
            else {
                break;
            }
        }
    }
}
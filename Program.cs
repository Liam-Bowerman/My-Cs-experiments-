using System;

class Program
{
    public static double number1; 
    public static double number2; 

    static void GetNumbers()
    {
    Console.WriteLine("Insert first number:");
    String num1 = Console.ReadLine();
    number1 = double.Parse(num1);
    Console.WriteLine("");
    Console.WriteLine("Insert second number:");
    String num2 = Console.ReadLine();
    number2 = double.Parse(num2);
    Console.Clear();
    }
    public static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("What type of problem do you want to do? To add enter a +. To subtract enter a -. To multiply enter an *. To divide with decimals enter a /.");
            Console.WriteLine("To find a remainder enter a %. If you want to do an exponent, type ^. If you would like to do fractions, enter x/x.");
            Console.WriteLine("");
            String equationType = Console.ReadLine();
            Console.WriteLine("");
            if (equationType == "x/x") 
            {
                Console.WriteLine("What will you do you want to do with fractions? +, -, *, /, or ^?");
                String fractionEquationType = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please enter first Numerator.");
                String numerator1 = Console.ReadLine();
                int numerator1Int = int.Parse(numerator1);
                Console.WriteLine("");
                Console.WriteLine("Please enter first denominator.");
                String denominator1 = Console.ReadLine();
                int denominator1int = int.Parse(denominator1);
                Console.WriteLine("");
                Console.WriteLine("Please enter second Numerator.");
                String numerator2 = Console.ReadLine();
                int numerator2Int = int.Parse(numerator2);
                Console.WriteLine("");
                Console.WriteLine("Please enter second denominator.");
                String denominator2 = Console.ReadLine();
                int denominator2int = int.Parse(denominator2);
                Console.WriteLine("");
                if (fractionEquationType == "+")
                {
                    Console.Clear();
                    
                }
                else if (fractionEquationType == "-")
                {
                    Console.Clear();
                }
                else if (fractionEquationType == "*")
                {
                    Console.Clear();
                }
                else if (fractionEquationType == "/")
                {
                    Console.Clear();
                }
                else if (fractionEquationType == "^")
                {
                    Console.Clear();
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Error, invalid input.");
                    break;
                }
            }
            else if (equationType == "+")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + (number1 + number2) + ".");
            }
            else if (equationType == "-")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + (number1 - number2) + ".");
            }
            else if (equationType == "*")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + (number1 * number2) + ".");
            }
            else if (equationType == "/")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + (number1 / number2) + ".");
            }
            else if (equationType == "%")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + (number1 % number2) + ".");
            }
            else if (equationType == "^")
            {
                GetNumbers();
                Console.WriteLine("Your answer is: " + Math.Pow(number1, number2) + ".");
            }
            else {
                Console.Clear();
                Console.WriteLine("Error, invalid input.");
                break;
            }
        }
    }
}
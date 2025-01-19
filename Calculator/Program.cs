// See https://aka.ms/new-console-template for more information


using System.Globalization;

string answer;
float num1;
float num2;
float result1;



Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("Please choose operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.WriteLine("Enter your choice: ");
answer = Console.ReadLine().ToLower();

if (answer == "5")
{
    Environment.Exit(0);
}

Console.WriteLine("Enter first number: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
num2 = float.Parse(Console.ReadLine());


if (answer == "1")
{
    result1 = num1 + num2;
    Console.WriteLine("The result is: " + result1);
}
else if (answer == "2")
{
    result1 = num1 - num2;
    Console.WriteLine("The result is: " + result1);
}
else if (answer == "3")
{
    result1 = num1 * num2;
    Console.WriteLine("The result is: " + result1);
}
else if (answer == "4")
{
    result1 = num1 / num2;
    Console.WriteLine("The result is: " + result1);
}
else
{
    result1 = num2 == 0 ? float.NaN : num1 / num2;
}
if (float.IsNaN(result1))
{
    Console.WriteLine("Cannot divide by zero");
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}


Console.ReadKey();


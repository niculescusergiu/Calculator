// See https://aka.ms/new-console-template for more information


using System.Globalization;

string answer;
int num1;
int num2;
int result1;



Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("Please choose operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");
Console.WriteLine("Enter your choice: ");
answer = Console.ReadLine();

if(answer == "5"){
    Environment.Exit(0);
}

Console.WriteLine("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

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
    Console.WriteLine("Invalid input");
}

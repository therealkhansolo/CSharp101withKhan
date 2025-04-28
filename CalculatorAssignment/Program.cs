//Welcome to Mr Khan's Calculator App(we all have to start somewhere 🙏🏾!)
/*
This application is a simple calculator. The user will input two 
numbers and the operation they want to perform (addition, 
subtraction, multiplication), and the program shall print the 
operation and the result.      
*/

Console.WriteLine("Hello there!");
Console.WriteLine("Input the first number: ");
var userNum1 = Console.ReadLine();
int num1 = int.Parse(userNum1);


Console.WriteLine("Input the second number: ");
var userNum2 = Console.ReadLine();
int num2 = int.Parse(userNum2);

Console.WriteLine("\nWhat do u want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("[D]ivide");
var userChoice = Console.ReadLine();

if (userChoice == "A" || userChoice == "a")
{
    Console.WriteLine($"{num1} + {num2} = {Addition(num1,num2)}");
}
else if (userChoice == "S" || userChoice == "s")
{
    Console.WriteLine($"{num1} - {num2} = {Subtraction(num1, num2)}");
}
else if (userChoice == "M" || userChoice == "m")
{
    Console.WriteLine($"{num1} * {num2} = {Multiplication(num1, num2)}");
}
else if (userChoice == "D" || userChoice == "d")
{
    Console.WriteLine($"{num1} / {num2} = {Division(num1, num2)}");
}
else
{
    Console.WriteLine("Invalid option!");
    Console.WriteLine("Exiting the calculator...........");
}

int Addition(int num1, int num2)
{
    return num1 + num2;
}

int Subtraction(int num1, int num2)
{
    return Math.Abs(num1 - num2);
}

int Multiplication(int num1, int num2)
{
    return (num1 * num2);
}

double Division(int num1, int num2)
{
    return Math.Abs((double)num1 / num2);
}
Console.ReadKey();

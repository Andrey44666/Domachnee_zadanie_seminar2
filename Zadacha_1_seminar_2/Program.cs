// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Enter number");
string? strNumber = System.Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if (number > 100 && number < 1000)
{
number = number % 100;
number = number / 10;
System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("number not three-digit");
}
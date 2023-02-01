// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
if ( number > 7)
{
    System.Console.WriteLine("This number is not a day of the week");
}
else if (number == 7 || number == 6)
{
    System.Console.WriteLine("Yes");
}
else if ( number <=5)
{
    System.Console.WriteLine("No");
}
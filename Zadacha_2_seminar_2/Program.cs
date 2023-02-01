// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Enter number");
int number = int.Parse(System.Console.ReadLine());
int numberB = 1000;
while (numberB <number)
{
    numberB = number * 10;
}
if  (number < 100)
{
    System.Console.WriteLine("Third digit is not");
}
else
{
    number = number % (numberB / 100);
    System.Console.WriteLine(number);
}       
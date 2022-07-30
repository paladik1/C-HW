//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num < 1000)
{
    int digitTwo = num / 10 % 10;
    Console.WriteLine("Вторая цифра: " + digitTwo);
}
if (num > 999)
{
    Console.WriteLine("Ваша цифра больше 999");
}

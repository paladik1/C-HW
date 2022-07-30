//Запишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 - 5
//78 - третьей цифры нет
//32679 - 6

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.Write("Третьй цифры нет");
    return;
}
if (num < 1000)
{
    int digitThird = num % 10;
    Console.WriteLine("Third number is " + digitThird);
}
if (num > 10000)
{
    int digitThird_10k = num / 100 % 10;
    Console.WriteLine("Third number is " + digitThird_10k);
    return;
}
if (num > 1000)
{
    int digitThird_1k = num / 10 % 10;
    Console.WriteLine("Third number is " + digitThird_1k);
}

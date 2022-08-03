//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите ваше число");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Введите необходимую степень");
int deg = int.Parse(Console.ReadLine());
int value = 3;
for (int power = 0; count <= 32; count++)
    Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})");

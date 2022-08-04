//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите ваше число");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num + 1];
Deg(array);
PrintArry(array);

void Deg(int[] num)
{
    int count = 0;
    int length = num.Length;
    while (count < length)
    {
        num[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 1;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

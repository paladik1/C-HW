﻿Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) {
    Console.Write("Вы ввели чётное число ");
} else if (num % 2 == 1) {
    Console.Write("Вы ввели нечётное число ");
}

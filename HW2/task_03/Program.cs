﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num <= 5)
{
    Console.Write("Ваше число " + num + " Этот день недели не является выходным");
}
if (num == 6 || num == 7)
{
    Console.Write("Ваше число " + num + " Этот день недели является выходным");
}
if ( num >= 8){
    Console.Write("Ваше число " + num + " Такого дня недели не существует");
}

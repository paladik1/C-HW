﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("ВВедите координату Х_1 ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату Y_1 ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату Z_1 ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату Х_2 ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату Y_2 ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координату Z_2 ");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками = " + GetLength(x1, y1, z1, x2, y2, z2));

double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return Distance;
}
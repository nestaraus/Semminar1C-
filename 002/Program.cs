﻿// Задача № 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> да
// a = 9, b= -3 -> да 
// a = -3, b = 9 -> да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{
    Console.WriteLine("Yes");
}   
else 
    Console.Write("No");
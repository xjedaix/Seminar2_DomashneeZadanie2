﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.Clear();
Console.Write ("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a < 1000)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
while (a >1000)
a /=10;
}
Console.WriteLine(a%10);

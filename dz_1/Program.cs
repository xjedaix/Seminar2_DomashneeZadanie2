// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ")
int num = int.Parse(Console.ReadLine());
int result = (num / 100) * 10 + num % 10;

Console.WriteLine ($"{num} -> {result}");
Console.WriteLine ($"{num} -> {num/100}{num%10}");
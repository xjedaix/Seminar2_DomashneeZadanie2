// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.Write("Введите номер дня недели: "); // WriteLine - выводит все что есть и переносит на новую строчку, Write - выводит на этой же строчке
int numberdayofweek = int.Parse(Console.ReadLine()); 

if (numberdayofweek == 6 || numberdayofweek == 7) 
{
  Console.WriteLine("(этот день выходной) -> да");
}
if(numberdayofweek < 1 || numberdayofweek > 7) // || - это означает "или", т.е если меньше 1 то переходим в цикл, если больше 7 то выходим из цикла
{
    Console.WriteLine("Введен неправильный номер ");
    return; // программа заканчивает дальнейшее действие, закончивает в этом случае действие
}
if (numberdayofweek == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberdayofweek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberdayofweek == 3)
{
    Console.WriteLine("Среда");
}
if (numberdayofweek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberdayofweek == 5)
{
    Console.WriteLine("Пятница");
}

if (numberdayofweek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberdayofweek == 7)
{
    Console.WriteLine("Воскресенье");
}

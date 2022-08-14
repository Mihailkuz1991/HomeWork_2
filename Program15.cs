// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите число -> {number}");

if (number > 7)
Console.Write("Некорректное число");

else
{
    if(number <= 5)
    Console.WriteLine ("Будний день");
    if(number > 5 )
    Console.WriteLine("Выходной");
}
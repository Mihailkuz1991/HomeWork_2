// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear(); 

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите число -> {number}");

if (number < 100)
Console.Write("Третьей цифры нет");

else 
{
    int thirdDigit = (number / 100) % 10;
    Console.WriteLine($"{number} -> {thirdDigit}");
    Console.Write(number);
}
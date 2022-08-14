// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear(); 

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите трехзначное число -> {number}");


void MaxDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - (firstDigit * 100) - thirdDigit) / 10;
    int numberLast = secondDigit;
    Console.WriteLine($"{number} -> {numberLast}");
}

MaxDigit(number); 



﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Введите число на проверку четности: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 != 0)
    {
        Console.WriteLine($"Число {number} НЕ является четным");
    }
else
    {
        Console.WriteLine($"Число {number} ЯВЛЯЕТСЯ четным");
    }
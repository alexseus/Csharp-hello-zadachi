/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetUserOption(string message)
{
    Console.Write(message);
    int n = int.Parse(Console.ReadLine()!);
    Console.Write($"N = {n} -> \"");
    return n;
}

void RecursionPrint(int n)
{
    if (n == 0) return;
    if (n == 1) Console.WriteLine(n + "\"");
    if (n > 1) Console.Write(n + ", ");
    RecursionPrint(n - 1);
}

int n = GetUserOption("Введите число N: ");
RecursionPrint(n);
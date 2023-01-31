/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetUserOption(string message)
{
    Console.Write(message);
    int userOption = int.Parse(Console.ReadLine()!);
    return userOption;
}

int SumCalc(int start, int finish)
{
    if (start == finish) return start;
    return start + SumCalc(start +1, finish);
}

int m = GetUserOption("Введите число M: ");
int n = GetUserOption("Введите число N: ");
int start = Math.Min(n,m);
int finish = Math.Max(n,m);
Console.Write($"M = {m}; N = {n} -> ");
int sumcalc = SumCalc(start,finish);
Console.WriteLine(sumcalc);

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
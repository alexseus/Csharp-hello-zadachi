/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetUserValue(string message)
{
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int userDigit = int.Parse(Console.ReadLine());
    Console. ResetColor();
    return userDigit;
}

int PowDigit(int digitA, int digitB)
{
    int result = digitA;
    for (int i = 1; i < digitB; i++)
    {
        result *= digitA;
    }
    return result;
}

void ShowResult(int resultAB)
{
    Console.Write($"Число A в степени B равно: ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(resultAB);
    Console. ResetColor();
}

Console.Clear();
int digitA = GetUserValue("Введите число A: ");
int digitB = GetUserValue("Введите число B: ");
int resultAB = PowDigit(digitA, digitB);
ShowResult(resultAB);

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetUserValue(string message)
{
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int userDigit = int.Parse(Console.ReadLine());
    Console. ResetColor();
    return userDigit;
}
int GetSumOfDigits(int userdigit)
{
    int sum = 0;
    while (userdigit != 0)
    {   
        sum += userdigit % 10;   
        userdigit = userdigit / 10;
    }
    return sum;
}
void ShowResult(int sum)
{
    Console.Write($"Сумма цифр в числе: ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(sum);
    Console. ResetColor();
}

Console.Clear();
int userDigit = GetUserValue("Введите число: ");
int sumdigits = GetSumOfDigits(userDigit);
ShowResult(sumdigits);
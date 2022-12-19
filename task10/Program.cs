/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int SecondDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int digit2 = number / 10 - digit1*10;
    return digit2;
}

Console.Clear();

Console.Write("Введите трехзначное число от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int second = SecondDigit(num);
    Console.WriteLine($"Вторая цифра: {second}");
}
else
{
    Console.WriteLine($"введеное число: {num} вне заданного диапазона");
}
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = (num % 100) % 10;
    Console.WriteLine($"третья цифра: {result}");
}

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    ThirdDigit(number);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

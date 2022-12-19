/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int TrirdDigit(int number)
{
    int digit3 = number % 10;
    int digit1 = number / 100;
    int digit2 = number / 10 - digit1*10;
    return digit2;
}

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

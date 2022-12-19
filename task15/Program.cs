/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void WeekDay(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

Console.Clear();

Console.Write("Введите цифру от 1 до 7 обозначающую день недели: ");
int weeknum = Convert.ToInt32(Console.ReadLine());
if ( weeknum > 0 && weeknum < 8 )
{
    WeekDay(weeknum);
}
else
{
    Console.WriteLine("Введенное число вне диапазона");
}
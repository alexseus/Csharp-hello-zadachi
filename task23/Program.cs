/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int getUserValue(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void cubeValue(int uservalue)
{
    for (int i = 1; i < uservalue; i++)
    {
        double cubeNumber = Math.Pow(i, 3);
        Console.Write($"{cubeNumber}, ");        
    }
    Console.WriteLine(Math.Pow(uservalue, 3));
}

int uservalue = getUserValue("Введите число от 1 до 10: ");
if (uservalue > 0 && uservalue < 11)
{
    cubeValue(uservalue);
}
else
{
    Console.WriteLine($"Введенная цифра {uservalue} вне диапазона");
}
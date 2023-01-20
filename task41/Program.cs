/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetUserData(string message)
{
    Console.Write(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int CountPositiveNumbers(int userData)
{
    int count = 0;
    for (int i = 0; i < userData; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        int temp = int.Parse(Console.ReadLine()!);
        if(temp > 0) count++;
    }
    return count;
}

int userData = GetUserData("Введите количество чисел для проверки: ");
int result = CountPositiveNumbers(userData);
Console.WriteLine($"Чисел > 0 = {result}");
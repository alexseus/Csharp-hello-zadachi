/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int MassiveLenght(string message)
{
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int lengthMassive = int.Parse(Console.ReadLine()!);
    Console. ResetColor();
    return lengthMassive;
}

int[] CreateMassive(int lenght)
{
    int[] userArray = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        Console.Write($"Введите {i+1} цифру массива: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        userArray[i] = int.Parse(Console.ReadLine()!);
        Console. ResetColor();
    }
    return userArray;
}

void ShowMassive(int[] massive)
{
    string result = "[";
    for (int i = 0; i < massive.Length; i++)
    {
        result = result + $"{massive[i]},";
    }
    result = result + $"\b]";
    Console.Write($"сформирован массив:");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(result);
    Console. ResetColor();
}

int lenght = MassiveLenght("Введите длину массива: ");    
int[] userArray = CreateMassive(lenght);
ShowMassive(userArray);
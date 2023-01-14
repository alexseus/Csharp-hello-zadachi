/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateMassive(string message)
{
    Console.Write(message);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int lengthMassive = int.Parse(Console.ReadLine()!);
    Console. ResetColor();
    int[] massive = new int[lengthMassive];
    for(int i = 0; i < lengthMassive; i++)
    {
        massive[i] = new Random().Next(0,100);    
    }
    return massive;
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
    
int[] result = CreateMassive("Введите длину массива: ");
ShowMassive(result);

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateArray()
{
    int str = new Random().Next(3,5);
    int col = new Random().Next(3,5);
    int[,] array = new int[str, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write($"\t[{i}]");
        Console.ResetColor();
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ShowColumnAverage(int[,] array)
{
    Console.WriteLine("Среднее арифметическое столбцов в массиве:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write($"\t[{i}]");
        Console.ResetColor();
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double colAverage = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            colAverage += array[j,i];
        }
        Console.Write("\t" + Math.Round(colAverage / (array.GetLength(0)) ,2));
    }
    Console.WriteLine();
}

Console.WriteLine("Сфомирован массив:");
int[,] array = CreateArray();
Show2DArray(array);
ShowColumnAverage(array);
/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

int[,] Create2DArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array2D = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2D[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2D;
}

int[,] Sort2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int n = 0;
        int j = 0;
        int temp = 0;
        while (n < array.GetLength(1) * (array.GetLength(1) -2))
        {
            temp = array[i, j];
            if (array[i, j + 1] > array[i, j])
            {
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
            if (array.GetLength(1) - 2 > j) j++;
            else j = 0;
            n++;
        }
    }
    return array;
}

void Print2DArray(int[,] array, string message)
{
    ShowInColor(message, ConsoleColor.DarkMagenta);
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(1); i++)
    {
        ShowInColor($"\t[{i}]", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        ShowInColor($"[{i}]\t", ConsoleColor.DarkGreen);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

int[,] array2D = Create2DArray(3, 11, 1, 10);
Print2DArray(array2D, "Created 2D array");
int[,] sortedArray2D = Sort2DArray(array2D);
Print2DArray(sortedArray2D, "Sorted row: max -> min 2D array");
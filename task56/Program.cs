/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int SearchMinRowSum(int[,] array)
{
    ShowInColor("сумма: ", ConsoleColor.DarkBlue);
    Console.WriteLine();
    int result = 0;
    int tempSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        Console.WriteLine($"стр. [{i}] = " + rowSum + "\t");
        if (i == 0)
        {
            tempSum = rowSum;
            result = i;
        }
        if (rowSum < tempSum)
        {
            tempSum = rowSum;
            result = i;
        }
        
    }
    Console.WriteLine();
    return result;
}

void Print2DArray(int[,] array, string message)
{
    ShowInColor(message, ConsoleColor.DarkBlue);
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

int[,] array2D = Create2DArray(4, 4, 1, 10);
Print2DArray(array2D, "Сформирован 2D массив: ");
int minRowSum = SearchMinRowSum(array2D);
ShowInColor($"минимальная сумма значений чисел в строке: ", ConsoleColor.DarkBlue);
Console.WriteLine(minRowSum);

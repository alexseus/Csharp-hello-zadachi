/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


int GetUserData(string message)
{
    Console.Write(message);
    int userdata = int.Parse(Console.ReadLine()!);
    return userdata;
}

int[,] CreateArray()
{
    int str = new Random().Next(3,10);
    int col = new Random().Next(3,10);
    int[,] array = new int[str, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}

void SearchUserDataInArray(int[,] array, int userdataStr, int userdataCol)
{
    if (userdataStr <= array.GetLength(0) && userdataCol <= array.GetLength(1))
    {
        Console.WriteLine($"Значение числа в массиве на позиции [{userdataStr},{userdataCol}] = {array[userdataStr,userdataCol]}."); 
    }
    else Console.WriteLine($"Заданные строка: {userdataStr} и столбец: {userdataCol} за пределами массива.");
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"\t[{i}]");
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

Console.WriteLine("Сфомирован массив:");
int[,] array = CreateArray();
Show2DArray(array);
int userdataStr = GetUserData("Ведите номер строки в массиве: ");
int userdataCol = GetUserData("Ведите номер столбца в массиве: ");
SearchUserDataInArray(array, userdataStr, userdataCol);

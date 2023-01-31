/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillArray(int[,] array)
{
    int step = 1;
    int x = 0;
    int y = 0;
    while (step < 4)
    {
        array[x,y] = step;
        y++;
        step++;
    }
    while (step < 7)
    {
        array[x,y] = step;
        x++;
        step++;
    }
    while (step < 10)
    {
        array[x,y] = step;
        y--;
        step++;
    }
    while (step < 12)
    {
        array[x,y] = step;
        x--;
        step++;
    }
    while (step < 14)
    {
        array[x,y] = step;
        y++;
        step++;
    }
    while (step < 15)
    {
        array[x,y] = step;
        x++;
        step++;
    }
    while (step < 17)
    {
        array[x,y] = step;
        y--;
        step++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];
FillArray(array);
PrintArray(array);
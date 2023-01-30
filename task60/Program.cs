/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/

int[,,] Create3DArray()
{
    int[,,] array = new int[2,2,2];
    int[] digitArray = new int[89];
    int random = 0;
    for (int i = 0; i < digitArray.Length; i++)
    {
        digitArray[i] = i + 10;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while(array[i,j,k] < 1)
                {
                    random = new Random().Next(0,90);
                    if (digitArray[random] > 0)
                    {
                        array[i,j,k] = digitArray[random];
                        digitArray[random] = 0;
                    }
                }
            }
        }
    }
    return array;
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + $"({i},{j},{k})\t");
            }
        }
        Console.WriteLine();
    }
}

int[,,] array = Create3DArray();
Print3DArray(array);
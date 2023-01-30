/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void Print2Martix(int[,] array1, int[,] array2)
{
    Console.WriteLine("Заданные матрицы: ");
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j] + "\t");
        }
        Console.Write("|\t");
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]}" + "\t");
        }
        Console.WriteLine();
    }

}

int[,] MatrixProd(int[,] array1, int[,] array2)
{
    int[,] arrayProd = new int[array1.GetLength(0),array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        
    }
    return arrayProd;
    
}

void PrindMatrix(int[,] array)
{
    Console.WriteLine("Произведение двух матриц равно: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array1 = Create2DArray(2, 2, 1, 10);
int[,] array2 = Create2DArray(2, 2, 1, 10);
Print2Martix(array1,array2);
int[,] matrixProd = MatrixProd(array1,array2);
PrindMatrix(matrixProd);
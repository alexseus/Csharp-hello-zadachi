/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] CreateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}

int MinMaxDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        
        if(array[i] > max)
        {
            max = array[i];
        }
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    int diff = max - min;
    return diff;
}

void ShowResult(int[] array, int diff)
{
    Console.Write("В сформировнном массиве: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine($"] разница между максимальным и минимальным числом: {diff}.");
}

int[] array = CreateArray(4);
int diff = MinMaxDiff(array);
ShowResult(array, diff);
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
    return array;
}

int OddPosSumCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            count += array[i];
        }
    }
    return count;
}

void ShowResult(int[] array, int count)
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
    Console.WriteLine($"] сумма чисел на нечетных позициях: {count}.");
}

int[] array = CreateArray(4);
int count = OddPosSumCount(array);
ShowResult(array, count);
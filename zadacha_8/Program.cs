// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine()!);

int index = 1;
Console.WriteLine($"Четные числа от 1 до {number}:");
while (index < number )
    {
        if (index % 2 == 0)
            {
                Console.Write($"{index}, ");
            }
        index++;
    }
Console.WriteLine("end");
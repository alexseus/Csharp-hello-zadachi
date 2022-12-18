// See Задача 0 = на вход принимает число и выдает квадрат этого числа

Console.Clear();

Console.Write("Ведите чило: ");
int number = int.Parse(Console.ReadLine()!);
int sqr = number * number;

Console.WriteLine($"Квадрат числа {number} равен {sqr}");
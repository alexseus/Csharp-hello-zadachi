/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetUserData(string message)
{
    Console.Write(message);
    double userData = int.Parse(Console.ReadLine()!);
    return userData;
}

double FindXDot(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    return x;
}
double FindYDot(double x, double b2, double k2)
{
    double y = k2 * x + b2;
    return y;
}

void ShowResult(double x, double y)
{
    Console.WriteLine($"Точка пересечения имеет координаты: ({x}; {y})");
}

Console.WriteLine("Для поиска точки пересечения линий аданных уравнениями y = k1*x + b1, y = k2*x + b2 введите значения:");
double b1 = GetUserData("b1: ");
double k1 = GetUserData("k1: ");
double b2 = GetUserData("b2: ");
double k2 = GetUserData("k2: ");
if (k1 == k2) Console.WriteLine("Линии не пересекаются");
else
{
    double x = FindXDot(b1, k1, b2, k2);
    double y = FindYDot(x, b2, k2);
    ShowResult(x, y);
}
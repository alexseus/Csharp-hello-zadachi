/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getUserValue(string message)
{
    Console.Write(message);
    int dotCoordinate = int.Parse(Console.ReadLine());
    return dotCoordinate;
}

double CoordinateDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow((bx-ax),2) + Math.Pow((by-ay),2) + Math.Pow((bz-az),2));
    result = Math.Round(result, 2);
    return result;
}

int ax = getUserValue("Ведите координаты точки A (x): ");
int ay = getUserValue("Ведите координаты точки A (y): ");
int az = getUserValue("Ведите координаты точки A (z): ");

int bx = getUserValue("Ведите координаты точки B (x): ");
int by = getUserValue("Ведите координаты точки B (y): ");
int bz = getUserValue("Ведите координаты точки B (z): ");

double distance = CoordinateDistance(ax, ay, az, bx, by ,bz);
Console.WriteLine($"Расстояние равно: {distance}");
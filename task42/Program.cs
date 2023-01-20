/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

string Fibonacci(int userData, int f1, int f2)
{
    string result = $"{f1} {f2}";
    for (int i = 0; i < userData; i++)
    {
        result = result + $"{f1+f2}";
                
    }
}

Fibonacci(4,0,1);
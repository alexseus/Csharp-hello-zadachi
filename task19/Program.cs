/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getUserValue(string message)
{
    Console.Write(message);
    int userValue = int.Parse(Console.ReadLine());
    return userValue;
}

void searchPalindrome(int number)
{
    if (number > 9999 && number < 1000000 )
    {
        int digit5 = number  % 10;
        int digit4 = (number % 100) / 10;
        int digit3 = (number % 1000) / 100;
        int digit2 = (number % 10000) / 1000;
        int digit1 = (number % 100000) / 10000;
        
        /* 
        Console.Write(digit1);
        Console.Write(digit2);
        Console.Write(digit3);
        Console.Write(digit4);
        Console.Write(digit5);
        */

        if (digit1 == digit5 && digit2 == digit4)
            {
                Console.WriteLine("да");
            }
        else
            { 
                Console.WriteLine("нет");
            }
    }
    else
    {
        Console.WriteLine($"Введенное число {number} не соответствует запросу.");
    }
}

int usernumber = getUserValue("Введите 5-ти значное число на проверку полиндрома: ");
searchPalindrome(usernumber);

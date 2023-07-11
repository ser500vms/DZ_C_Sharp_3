// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Решение через string:

// void Polindrom(string num)
// {
//     if (num[0] == num[4] & num[1] == num[3])
//     {
//         Console.Write(num + " -> да");
//     }
//     else
//     {
//         Console.Write(num + " -> нет");
//     }
// }

// string GetInput(string text)
// {
//     Console.Write(text);
//     return Console.ReadLine();
// }

// string number = GetInput("Введите 5-ти значное число: ");
// Polindrom(number);

//Решение через int:

void Polindrom(int num)
{
    if (num % 10 == num % 10000 & num % 100 == num % 1000)
    {
        Console.Write(num + " -> да");
    }
    else
    {
        Console.Write(num + " -> нет");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите 5-ти значное число: ");
Polindrom(number);
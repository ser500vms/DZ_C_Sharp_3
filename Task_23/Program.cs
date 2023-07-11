// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Square (int n)
{
    
for (int i = 1; i <= n-1; i++)
{
    Console.Write(i*i*i + ", ");
}

Console.Write(n*n*n);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
n = Math.Abs(n);
Console.Write ($" {n} -> ");
Square(n);
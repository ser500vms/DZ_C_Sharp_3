// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowQuater(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    Console.WriteLine ($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}), -> {Math.Round(distance, 2)}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int xa = GetInput("Введите координаты xa: ");
int ya = GetInput("Введите координаты xb: ");
int za = GetInput("Введите координаты ya: ");
int xb = GetInput("Введите координаты yb: ");
int yb = GetInput("Введите координаты za: ");
int zb = GetInput("Введите координаты zb: ");

ShowQuater(xa, ya, za, xb, yb, zb);
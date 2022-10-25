//                                      Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите ряд чисел через пробел:");
int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Mass(arr);

int Mass(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел равно: {count}");
    return count;
}

//                                      Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2:");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2:");
double k2 = double.Parse(Console.ReadLine()!);

double x = 1;
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

Console.WriteLine($"Координаты пересечения двух прямых: ({X(b1, k1, b2, k2)},{Y(b2, k2, X(b1, k1, b2, k2))})");


double X(double b1, double k1, double b2, double k2)
{
    x = (b1 - b2) / (k2 - k1);
    return x;
}

double Y(double b1, double k1, double X)
{
    double y = k1 * X + b1;
    return y;
}
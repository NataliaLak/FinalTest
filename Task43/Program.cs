// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return $"({x.ToString()}, {y.ToString()})";
}

double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

    double b1 = GetInput("Введите значение b1: ");

    double k1 = GetInput("Введите значение k1: ");

    double b2 = GetInput("Введите значение b2: ");

    double k2 = GetInput("Введите значение k2: ");

    string intersectionPoint = GetIntersectionPoint(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения прямых: {intersectionPoint}");
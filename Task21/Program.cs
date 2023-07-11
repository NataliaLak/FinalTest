// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowDistance(double a1, double a2, double a3, double b1, double b2, double b3)
{
    double distance = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2));


   Console.WriteLine ($"Расстояние между двух точек: {distance}");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double a1 = GetInput("Введите координату Х точки А: ");
double a2 = GetInput("Введите координату Y точки А: ");
double a3 = GetInput("Введите координату Z точки А: ");
double b1 = GetInput("Введите координату Х точки B: ");
double b2 = GetInput("Введите координату Y точки B: ");
double b3 = GetInput("Введите координату Z точки B: ");

ShowDistance(a1, a2, a3, b1, b2, b3);
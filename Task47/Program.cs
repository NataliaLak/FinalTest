// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print2dMassive(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(massive[i, j],1)}\t ");
        }
        Console.WriteLine();
    }
}

double[,] Create2dMassive(int rows, int columns, double startValue, double finishValue)
{
    Random random = new Random();
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * (finishValue - startValue) + startValue;
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = (int)GetInput("Введите количество строк массива: ");
int n = (int)GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2dMassive(m, n, -99, 99);
Print2dMassive(massive);
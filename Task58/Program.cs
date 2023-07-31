// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ProductTwoMatrix(int[,] array1, int[,] array2, int[,] resultMatrix)
{
    int rows1 = array1.GetLength(0);
    int cols1 = array1.GetLength(1);
    int rows2 = array2.GetLength(0);
    int cols2 = array2.GetLength(1);

    if (cols1 != rows2)
    {
        Console.WriteLine("Количество колонок первой матрицы должно быть равно количеству строк второй матрицы.");
        return;
    }

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                resultMatrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    Console.WriteLine($"Результирующая матрица: ");

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            Console.Write($"{resultMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray2D(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateSecondRandomArray2D(int rows, int columns, int start, int finish)
{
    int[,] array2 = new int[rows, columns];
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array2;
}


int[,] GenerateFirstRandomArray2D(int rows, int columns, int start, int finish)
{
    int[,] array1 = new int[rows, columns];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array1;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m1 = GetInput("Введите количество строк первой матрицы: ");
int n1 = GetInput("Введите количество столбцов первой матрицы: ");
int[,] array1 = GenerateFirstRandomArray2D(m1, n1, 0, 10);

int m2 = GetInput("Введите количество строк второй матрицы: ");
int n2 = GetInput("Введите количество столбцов второй матрицы: ");
int[,] array2 = GenerateSecondRandomArray2D(m2, n2, 0, 10);

Console.WriteLine("Сгенерированы двумерные массивы:");
PrintArray2D(array1, array2);

Console.WriteLine();

int[,] resultMatrix = new int[m1, n2];

ProductTwoMatrix(array1, array2, resultMatrix);
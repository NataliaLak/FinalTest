// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindMinSumRow(int[,] array)
{
    int minSum = 0;
    int rowIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (i == 0) minSum = rowSum;
        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowIndex = i;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (rowIndex + 1) + " строка");
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandomArray2D(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк: ");
int n = GetInput("Введите количество столбцов: ");
int[,] array = GenerateRandomArray2D(m, n, 0, 100);

Console.WriteLine("Сгенерирован двумерный массив:");
PrintArray2D(array);

Console.WriteLine();

FindMinSumRow(array);
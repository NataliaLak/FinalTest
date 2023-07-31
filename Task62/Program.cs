// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array, int rows, int columns)
{
    int num = 1;
    int rowStart = 0, rowEnd = rows - 1, colStart = 0, colEnd = columns - 1;

    while (num <= rows * columns)
    {
        for (int i = colStart; i <= colEnd; i++)
            array[rowStart, i] = num++;
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
            array[i, colEnd] = num++;
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
            array[rowEnd, i] = num++;
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
            array[i, colStart] = num++;
        colStart++;
    }
}

void Print2DArray(int[,] array)
{
    Console.WriteLine("Массив заполненный спирально:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int[,] array = new int[m, n];

FillSpiralArray(array, m, n);
Print2DArray(array);

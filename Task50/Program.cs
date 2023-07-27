// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void GetElement(int[,] array, int number)
{
    bool numberExist = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                numberExist = true;
                Console.WriteLine($"{number} -> есть в массиве");
                break;
            }

        }

    }
    if (numberExist == false)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}
void Print2dMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] Create2dMassive(int rows, int colums, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, colums];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int number = GetInput("Введите искомый элемент массива: ");
int[,] massive = Create2dMassive(m, n, -99, 99);
Print2dMassive(massive);
Console.WriteLine();
GetElement(massive, number);
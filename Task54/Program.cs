// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortRowsDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // Сортировка элементов в текущей строке по убыванию
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        // Обмен значениями, чтобы получить убывающий порядок
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
         Print2DArray(array);
    }

void Print2DArray (int [,] array)
{
    Console.WriteLine("Новый массив выглядит так:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i,j]);
        }
    Console.WriteLine();
    }
}

int[,] Create2DArray (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next (1,10);
            Console.Write(" " + array[i,j]);
        }
    Console.WriteLine();
    }
    return array;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int [,] array = Create2DArray(rows, columns);
SortRowsDescending(array);


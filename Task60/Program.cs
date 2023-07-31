// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t", -3);
            }
            Console.WriteLine();
        }
    }
}
int[,,] GenerateRandomArray3D(int sizeX, int sizeY, int sizeZ, int start, int finish)
{
    int[,,] matrix = new int[sizeX, sizeY, sizeZ];
    for (int x = 0; x < sizeX; x++)
    {
        for (int y = 0; y < sizeY; y++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                matrix[x, y, z] = new Random().Next(start, finish);
            }
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x = GetInput("Введите количество строк массива: ");
int y = GetInput("Введите количество столбцов массива: ");
int z = GetInput("Введите глубину массива: ");

int[,,] array = GenerateRandomArray3D(x, y, z, 10, 100);
Print3dArray(array);
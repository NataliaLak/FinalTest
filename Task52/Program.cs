// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetArithmeticMean(int[,] array, int rows, int cols)
{ 
    double[] columnAverages = new double[cols];
    for (int j = 0; j < cols; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = sum / rows;
        }
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{columnAverages[j]:N1} ");
        }
} 
 
 
void PrintTwoDimensionalArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]}\t", -3); 
        } 
        Console.WriteLine(); 
    } 
} 
 
int[,] GenerateTwoDimensionalArray(int rows, int columns, int startValue, int finishValue) 
{ 
    int[,] workingArray = new int[rows, columns]; 
    for (int i = 0; i < workingArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < workingArray.GetLength(1); j++) 
        { 
            workingArray[i, j] = new Random().Next(startValue, finishValue + 1); 
        } 
    } 
    return workingArray; 
} 
 
int GetInput(string text) 
{ 
    Console.Write(text); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
int m = GetInput("Введите количество строк массива: "); 
int n = GetInput("Введите количество столбцов массива: "); 
int[,] array = GenerateTwoDimensionalArray(m, n, 1, 9); //берём от 1 до 9 
PrintTwoDimensionalArray(array); 
Console.WriteLine(); 
GetArithmeticMean(array, m, n);
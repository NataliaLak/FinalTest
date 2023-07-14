// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100);
    }
}

int[] array = new int[8];
FillArray(array);

string firstRow = string.Join(", ", array.Take(5));
string secondRow = string.Join(", ", array.Skip(5).Take(3));

Console.WriteLine("Рандомный массив из 8 элементов:");
Console.WriteLine($"[{firstRow}]");
Console.WriteLine($"[{secondRow}]");



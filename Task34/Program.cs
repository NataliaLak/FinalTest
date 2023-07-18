// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) // Проверка на четность
        {
            count++;
        }
    return count;
}

int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000); // Генерация случайного трехзначного числа
    }
    return array;
}

int[] numbers = GenerateRandomArray(4); // Замените 4 на желаемый размер массива
Console.WriteLine("Задайте массив:");
Console.WriteLine($"[{String.Join(",", numbers)}]");

int evenCount = CountEvenNumbers(numbers);
Console.WriteLine("Количество четных чисел: " + evenCount);
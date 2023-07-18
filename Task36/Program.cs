// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int CalculatePositionSum(int[] array)
    {
        int sum = 0;
        
        for (int i = 1; i < array.Length; i += 2) // Обход элементов на нечетных позициях
        {
            sum += array[i];
        }
        
        return sum;
}

int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100); // Генерация случайного трехзначного числа
    }
    return array;
}

int[] numbers = GenerateRandomArray(4); // Замените 4 на желаемый размер массива
Console.WriteLine($"[{String.Join(",", numbers)}]");

int result = CalculatePositionSum(numbers);
Console.WriteLine("Сумма элементов на нечетных позициях: " + result);
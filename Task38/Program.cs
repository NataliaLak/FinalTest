// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];

        if (array[i] > max)
            max = array[i];
    }

    double difference = max - min;
    return difference;
}
double[] GenerateRandomArray(int elements, double start, double finish)
{
    double[] array = new double[elements];
    Random random = new Random();

    for (int i = 0; i < elements; i++)
    {
        array[i] = Math.Round((start + new Random().NextDouble()*(finish-start)), 2);
    }
    return array;
}

double[] numbers = GenerateRandomArray(5, 0, 100); 
Console.WriteLine($"[{String.Join(";", numbers)}]");

double difference = Difference(numbers);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {Math.Round(difference,2)}");

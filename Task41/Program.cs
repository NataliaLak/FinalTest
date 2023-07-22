// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositive(int[] numbers)
{
    int countPositive = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            countPositive++;
        }
    }

    return countPositive;
}

int[] GenerateRandomArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101); // Генерация случайного числа
    }
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите количество чисел M: ");
int[] numbers = GenerateRandomArray(5); // Замените 5 на желаемый размер массива
Console.WriteLine($"{String.Join(",", numbers)}");
int result = CountPositive(numbers);
Console.WriteLine($"Количество чисел больше 0: {result}");
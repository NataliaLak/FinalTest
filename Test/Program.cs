// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“3”, “Denmark”, “Kazan”] → []

string[] GetThreeSymbol(string[] array)
{
    // Считаем, сколько строк удовлетворяют условию
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    
    // Создаем новый массив на основе подсчитанного количества строк
    string[] resultArray = new string[count];

    // Копируем строки из исходного массива в новый массив
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }
    }

    return resultArray;
}

string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элементы массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество строк в массиве: ");
string[] array = CreateArray(size);
Console.Write($"[{string.Join(",", array)}] ");
string[] newArray = GetThreeSymbol(array);
Console.WriteLine($"-> [{string.Join(",", newArray)}]");

// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetThreeSymbol(string[] inputArray)
{
    if (inputArray.Length == 0)
    {
        return new string[0];
    }

    int count = 0;

    // Считаем, сколько строк удовлетворяют условию
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count]; // Создаем новый массив на основе подсчитанного количества строк

    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элементы массива");
        array[i] = Console.ReadLine();
    }
    return array;
}
int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Введите количество строк в массиве: ");
string[] array = CreateArray(size);

string[] newArray = GetThreeSymbol(inputArray);
Console.WriteLine($"[{string.Join(",", newArray)}]");

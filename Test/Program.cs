// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetThreeSymbol(string[] inputArray)
    {
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

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];


string[] newArray = GetThreeSymbol(array);
        Console.WriteLine($"[{string.Join(",", newArray)}]");


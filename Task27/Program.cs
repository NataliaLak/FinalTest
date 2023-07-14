// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number)
{
   int sum = 0;
        while (number > 0) 
        {
            sum += number % 10;
            number /= 10;

        }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите число :");
int result = GetSum(number);
Console.WriteLine($"Сумма чисел от {number} -> {result}");

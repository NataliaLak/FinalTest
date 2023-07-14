//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 


int GetCounts(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    return result;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int numberA = GetInput("Введите число A:");
int numberB = GetInput("Введите число B:");
int result = GetCounts(numberA, numberB);
Console.WriteLine($"Возведение в натуральную степень {numberA}, {numberB} -> {GetCounts(numberA, numberB)}");

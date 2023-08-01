// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumElement(int startNumber, int finishNumber)
{
    if (finishNumber == startNumber) return startNumber;
    return  startNumber + GetSumElement(startNumber + 1, finishNumber);
}
Console.Write("Введите M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M{number1}; N{number2} -> {GetSumElement(number1, number2)}");

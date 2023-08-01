// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermann(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if (number2 == 0) return GetAckermann(number1 - 1, 1);
    return GetAckermann(number1 - 1, GetAckermann(number1, number2 - 1));       
}

Console.Write("Введите M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {number1}; N = {number2} -> A (M, N) = {GetAckermann(number1, number2)}");
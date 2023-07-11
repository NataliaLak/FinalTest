// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Vyvod (int n)
{
Console.WriteLine($"Таблица кубов чисел в промежутке от 0 до {n}:", n);

for (int i = 0; i < n; i++)
{
    Console.Write(i*i*i+", ");
}

Console.Write(n*n*n);

}

Console.Write("Введите число N:");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);

Vyvod(n);
// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из них.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int Max = number1;

if (number1 > Max) Max = number1;
if (number2 > Max) Max = number2;
if (number3 > Max) Max = number3;

Console.WriteLine("Максимальное число: " + Max);
 

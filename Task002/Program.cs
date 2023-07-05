// Напишите программу, которая на вход принимает 2 числа и выдаёт какое число больше.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Большее число: " + number1);
}
else if(number1 < number2)
{
    Console.WriteLine("Большее число: " + number2);
}
 else
    Console.WriteLine("Оба числа равны.");   


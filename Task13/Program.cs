// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if  (number / 100 < 1)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    while (number/1000 >= 1)
    {
        number = (number - number % 10) / 10;
    }
    int thirdDigith = number % 10;

    Console.WriteLine($"Третья цифра числа {number}: {thirdDigith}");

}




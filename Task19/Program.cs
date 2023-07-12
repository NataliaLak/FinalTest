// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Pаlindrom(int n)
{
int firstDigit = n / 10000;
int secondDigit = n / 1000 % 10;
int fourthDigit = n / 10 % 10;
int lastDigit = n % 10;

    if (firstDigit == lastDigit & secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {n} -> палиндром");
    }
    else
        Console.WriteLine($"Число {n} -> не палиндром.");

}

Console.Write("Введите пятизначное число:");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);


Pаlindrom(n);
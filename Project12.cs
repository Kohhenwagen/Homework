// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int sum = 0;
while (n > 0)
{
    int x = n % 10;
    sum = sum + x;
    n = n / 10;
}
Console.Write($"Сумма цифр в числе: {sum}");
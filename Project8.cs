// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int rev = 0;
while (n > 0)
{
    int x = n % 10;
    rev = rev * 10 + x;
    n = n / 10;
}
if (num == rev)
{
    Console.Write("Число является палиндромом");
}
else 
{
    Console.Write("Число не является палиндромом");
}
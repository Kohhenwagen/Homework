// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100) 
{
    while (num >= 1000) 
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.Write($"Третья цифра:{result}");
}
else
{
    Console.Write("Третьей цифры нет");
}

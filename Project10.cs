// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// for (int index = 0; index < N; index++)
// {
//     array[index] = Convert.ToInt32(Math.Pow(index + 1, 3));
//     Console.WriteLine(array[index]);
// }

// На семинаре делали похожую  задачу, но там делали через массивы, я если честно не совсем понял для чего было их вводиnь если без массива тоже все работает, поэтому решил попробовать сделать короче

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < N; index++)
{
    Console.WriteLine(Convert.ToInt32(Math.Pow(index + 1, 3)));
}

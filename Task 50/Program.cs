// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine ("Задайте количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Задайте количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int [,] array = new int [m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(0, 21);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите число от 0 до 20: ");
int num = int.Parse(Console.ReadLine());
bool isInArray = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array [i, j] == num)
        {
            isInArray = true;
            break;
        }
    }
}

if (isInArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array [i, j] == num)
            {
            Console.WriteLine ($"Число {num} есть в массиве.");
            Console.WriteLine ($"Его индексы: {i}, {j}");
            break;
            }
        }
    }
}
else
{
    Console.WriteLine($"Число {num} отсутствует в массиве");
}
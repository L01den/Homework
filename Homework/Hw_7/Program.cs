/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
 */

void Print(double[,] arr)
{
 for (int i = 0; i < arr.GetLength(0); i++)
 {
 for (int j = 0; j < arr.GetLength(1); j++)
 {
 Console.Write(arr[i, j] + " ");
 }
 Console.WriteLine();
 }
}

Console.WriteLine("Введите размер массива:");
int m = int.Parse(Console.ReadLine()); 
int n = int.Parse(Console.ReadLine());

double[,] mass = new double[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
 for (int j = 0; j < mass.GetLength(1); j++)
 {
 mass[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
 mass[i, j] = Math.Round(mass[i, j], 2);
 }
}

Print(mass);
Console.WriteLine(); 


/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 20);
    }
}

Console.WriteLine("Введите искомый индекс числа:");
int firstIndex = int.Parse(Console.ReadLine());
int secondIndex = int.Parse(Console.ReadLine());

if (firstIndex < mass.GetLength(0) && secondIndex < mass.GetLength(1))
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        if (i == firstIndex)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (j == secondIndex)
                {
                    Console.WriteLine($"Искомое число: {mass[i, j]}");
                }
            }
        }
    }
}
else 
{
    Console.WriteLine("Вы вышли за размер массива");
}
Console.WriteLine();
Console.WriteLine("Наш массив:");
Print(mass); 


/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
 */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 20);
    }
}

Print(mass);
Console.WriteLine();

double sum = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum += mass[i, j];
    }
    Console.Write($"{Math.Round(sum / mass.GetLength(0), 2)}");
}

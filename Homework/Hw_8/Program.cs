/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

/* 
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

Console.WriteLine("Введите размер массива:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 20);
    }
}

Console.WriteLine("Наш массив:");
Print(mass);
Console.WriteLine();

int temp = mass[0, 0];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = j + 1; k < mass.GetLength(1); k++)
        {
            if (mass[i, j] > mass[i, k])
            {
                temp = mass[i, j];
                mass[i, j] = mass[i, k];
                mass[i, k] = temp;
            }
        }
    }
}
Print(mass); */


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

void PrintTwoDim(int[,] arr)
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

//void PrintOneDim(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 20);
    }
}

Console.WriteLine("Наш массив:");
PrintTwoDim(mass);
Console.WriteLine();

int sum = 0;
int[] arr = new int[m];
int k = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        sum += mass[i, j];
    }
    arr[k] = sum;
    k++;
    sum = 0;
}

int min = arr[0];
for (int i = 1; i < arr.Length; i++)
    {
        min = Math.Min(min, arr[i]);
    }

int pos = 0;
while(pos < m)
{
    if( arr[pos] == min)
    {
        Console.WriteLine($"Строчка с наименьшей суммой элементов находиться под индексом - {pos}, сумма равна {min}.");
    }
    pos++;
}

// PrintOneDim(arr);
// Console.WriteLine(min);





/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */


/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента. */


/* Задача 62: Заполните спирально массив 4 на 4. */

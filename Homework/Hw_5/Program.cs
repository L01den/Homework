/* Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

void PrintArray(int [] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}  

int[] arr = new int[9];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
}

PrintArray(arr);

int count = 0;

int CountEven(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i]%2 == 0) count++;        
    }
    return count;
}
CountEven(arr);
Console.WriteLine($"Колличество чётных чисел в массиве: {count}");  

/* Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях. */

int[] arr = new int[6];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
}

PrintArray(arr);

int sum = 0;

int SumUnEvenPos(int[] collection)
{
    for (int i = 1; i < collection.Length; i += 2) 
    {
        sum += collection[i]; 
    }
    return sum;
}
SumUnEvenPos(arr);
Console.WriteLine($"Сумма элементов массива, стоящх на не чётных позициях: {sum}");   

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */


void PrintArray(double[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

double[] arr = new double[6];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round(new Random().NextDouble(), 3);
}

Console.WriteLine("Наш массив:");
PrintArray(arr);

double max = 0;
double min = 1;
double diff = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];

}
for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i]) min = arr[i];

}

Console.WriteLine($"Разница между максимальным и минимальным {Math.Round(diff=max-min, 3)}");


 
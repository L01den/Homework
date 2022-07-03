/* Задача 25 Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B. */

Console.WriteLine("Введите 2 числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int deg = A;

for (int i = 0; i < B - 1; i++)
{
    deg *= A;
}

Console.WriteLine(deg); 

/* Задача 27 Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе. */

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int sum = 0;
while (num > 0)
{
    sum += num % 10;
    num /= 10;
}

Console.WriteLine(sum); 

/* Задача 29 Напишите программу, которая задаёт массив
из и выводит их на экран. */

void PrintArray(int [] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите желаемый размер массива:");
int n = int.Parse(Console.ReadLine());

int [] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}

PrintArray(array);
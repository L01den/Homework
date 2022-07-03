// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

while (num < 10000 | num > 99999)
{
    Console.WriteLine("Введите пятизначное число: ");
    num = int.Parse(Console.ReadLine());
}
if (((num / 10000) == (num % 10)) && ((num / 1000 % 10) == (num % 100 / 10)))
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}

// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.


Console.WriteLine("Введите первые 3 кординаты:");
double X1 = double.Parse(Console.ReadLine());
double Y1 = double.Parse(Console.ReadLine());
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторые 3 кординаты:");
double X2 = double.Parse(Console.ReadLine());
double Y2 = double.Parse(Console.ReadLine());
double Z2 = double.Parse(Console.ReadLine());

double X = Math.Round(Math.Pow((X2 - X1), 2), 3);
double Y = Math.Round(Math.Pow((Y2 - Y1), 2), 3);
double Z = Math.Round(Math.Pow((Z2 - Z1), 2), 3);

Console.WriteLine(Math.Round(Math.Sqrt(X + Y + Z), 2));


// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Напишите число, до какого числа считать:");
double N = double.Parse(Console.ReadLine());

while (N % 1 != 0)
{
    Console.WriteLine("Напишите целое число:");
    N = double.Parse(Console.ReadLine());
}

int i = 1;
if (N < 1)
{
    while (i >= N)
    {
        Console.Write(i + " ");
        Console.WriteLine(Math.Pow(i, 2) + " ");
        i -= 1;
    }
}
else
{ 
    while (i <= N)
    {
        Console.Write(i + " ");
        Console.WriteLine(Math.Pow(i, 3) + " ");
        i++;
    }
} 
/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа. */

Console.WriteLine("Ведите число");

int num = int.Parse(Console.ReadLine());
while (num < 100 | num > 999)
{
    Console.WriteLine("Введите трёхзначное число");
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine(num = num / 10 % 10);

// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Ведите число дня недели: ");

int Day = int.Parse(Console.ReadLine());

while (Day <1 | Day >7)
{
    Console.WriteLine("Нет такого дня недели введите число от 1 до 7");
    Day = int.Parse(Console.ReadLine());
}

if (Day==6 ^ Day==7)  
{
    Console.WriteLine("Это выходной!!!");
}
else Console.WriteLine("Это будний:( день ");


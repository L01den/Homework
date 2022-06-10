/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее. */

Console.WriteLine("Введите числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b )
{
Console.Write("Число" + " " + a + " " + "больше");
}
else
{
Console.WriteLine("Число" + " " + b + " " + "больше");
}

/* Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел. */

/* Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if ( b > max)
{
max = b;
}
if ( c > max )
{
max = c;
}
Console.Write("Максимальное число:" + " " + max); */

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка). */


/* Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
Console.Write("Число" + " " + a + " " + "чётное");
}
else
{
Console.Write("Число" + " " + a + " " + "нечётное");
} */

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
 */

/* Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
{
        Console.Write (i + " ");
}
    i++;
}
 */



/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите числа");
string m = Console.ReadLine();
string[] num = m.Split(' ');
int[] mass = new int[num.Length];

for (int i = 0; i < num.Length; i++)
{
    mass[i] = int.Parse(num[i]);
}

int count = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0) 
    {
        count ++;
    }

}

Console.WriteLine(count);  


/* Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */

Console.WriteLine("Введите первый отрезок:");
double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второй отрезок:");
double k1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());

if(b1 == k1)
{
    Console.WriteLine("Прямые не пересекаються");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых ({Math.Round(x, 2)}, {Math.Round(y, 2)})"); 
}



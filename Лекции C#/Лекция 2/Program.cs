int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1;
int b1 = 2;
int c1 = 344;

int a2 = 4;
int b2 = 51;
int c2 = 6;

int a3 = 7;
int b3 = 8;
int c3 = 9;

/* int maxim1 = Max(a1, b1, c1);
int maxim2 = Max(a2, b2, c2);
int maxim3 = Max(a3, b3, c3);
int Maxi = Max(maxim1, maxim2, maxim3); */

int Maxi = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write(Maxi);

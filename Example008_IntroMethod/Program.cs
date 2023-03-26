int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int a1 = 23;
int a2 = 18;
int a3 = 43;
int b1 = 18;
int b2 = 26;
int b3 = 312;
int c1 = 56;
int c2 = 78;
int c3 = 36;


//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.WriteLine(max);
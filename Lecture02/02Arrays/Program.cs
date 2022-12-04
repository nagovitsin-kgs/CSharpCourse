int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;                       // сказали, что result равен максимальному значению arg1  
    if (arg2 > result) result = arg2;       // условие, если да, то result arg2 максимальное значение
    if (arg3 > result) result = arg3;       // условие, если да, то result arg3 максимальное значение
    return result;                          // чтобы наш метод, возвращал result
}
int[] array {18, 52, 23, 24, 51, 61, 75, 84, 58};

// int max1 = Max(a1, b1, c1); 
// int max2 = Max(a2, b2, c2); 
// int max3 = Max(a3, b3, c3); 

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max); // вывод максимального значения     
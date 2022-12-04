// See https://aka.ms/new-console-template for more information

Console.WriteLine("Найти максимальное число из 9 число с помощью функции (метода)."); // условие задачи


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;                       // сказали, что result равен максимальному значению arg1  
    if (arg2 > result) result = arg2;       // условие, если да, то result arg2 максимальное значение
    if (arg3 > result) result = arg3;       // условие, если да, то result arg3 максимальное значение
    return result;                          // чтобы наш метод, возвращал result
}


int a1 = 15;   // ввели переменую a1
int b1 = 21;   // ввели переменую b1
int c1 = 39;   // ввели переменую c1
int a2 = 33;   // ввели переменую a2
int b2 = 23;   // ввели переменую b2
int c2 = 33;   // ввели переменую c2
int a3 = 13;   // ввели переменую a3
int b3 = 23;   // ввели переменую b3
int c3 = 33;   // ввели переменую c3

// int max1 = Max(a1, b1, c1); 
// int max2 = Max(a2, b2, c2); 
// int max3 = Max(a3, b3, c3); 

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max); // вывод максимального значения
     
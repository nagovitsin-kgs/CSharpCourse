﻿/* ДВУМЕРНЫЕ МАССИВЫ:*/
//                           указывает или возвращает кол-во строк в вашем массиве -    |-строки matrix.GetLength(0)   
//ТИП ДАННЫХ(int)[,] НАИМЕНОВАНИЕ МАССИВА(matrix) = (ОПЕРАТОР ПРИСВАИВАНИЯ)new ТИП(int)[5, 8];
//                        указывает или возвращает кол-во столбцов в вашем массиве -       |-столбцы matrix.GetLength(1)
/* Массив с типом строки:
string[,] table = new string[2, 5]; // он же многомерный массив, 2 (строки), 5 (столбцы).
//string.Empty                                   // инициализация для строк происходит, вот такой константой.
//table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4] // строка с индексом 0 и столбцы с 0 до 4.
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4] // строка с индексом 1 и столбцы с 0 до 4.

table[1, 2] = "слово";   // наименование массива, задаём значение элемента 1(индекс строки) и 2 (индекс столбца). Работаем как буд-то это переменная.
// используем цикл в цикле, чтобы распечатать данный массив.
for (int rows = 0; rows < 2; rows++)   // rows (строки)
{
    for (int columns = 0; columns < 5; columns++)    // columns (столбцы, колонки)
    {
        Console.WriteLine($"--{table[rows, columns]}--"); // выводим: обащаемся к массиву и индексам строк и столбцов. Добавим чёрточки, чтобы увидеть на консоле...
    }
}                                            
*/
/*Вариант 1. Массив с типом числа:
// для массива с числами заданными 3 и 4.

int[,] matrix = new int[3, 4];  

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine(); // после того как вывели столбцы через пробел, принудительно выводим на пустые строки - строки по i.
}
*/

/* Вариант 2. Массив с типом числа: 
// для массива с числами для работы в методах или циклах (функциях) необходимо вот так (условие i и j через):

int[,] matrix = new int[3, 4];  

for (int i = 0; i < matrix.GetLength(0); i++)       // matrix.GetLength(0) = 3 для строк (о - это кол-во строк) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)   // matrix.GetLength(1) = 4 для столбцов (1 - это кол-во столбцов)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine(); // после того как вывели столбцы через пробел, принудительно выводим на пустые строки - строки по i.
}
*/

//------------------------------МЕТОД-------------------------------------//
/* Опишем МЕТОД, который будет описывать, решать и заполнять числами) наш двумерный массив:

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr) // этот метод PrintArray принимает в качестве аргументов matr двумерную таблицу чисел (int[,] и будет её печатать matrix
{
    for (int i = 0; i < matr.GetLength(0); i++)       // matrix.GetLength(0) = 3 для строк (о - это кол-во строк) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // matrix.GetLength(1) = 4 для столбцов (1 - это кол-во столбцов)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // после того как вывели столбцы через пробел, принудительно выводим на пустые строки - строки по i.
    }
}

//int[,] matrix = new int[3, 4]; // !!! для удобства видимости, чтобы код был скомпанованым можно перетащить сверху....
PrintArray(matrix); // вызываем метод на печать, консоль...
*/
// ------ продолжение -------:
/* Дополнительный МЕТОД, который будет описывать, решать и заполнять СЛУЧАЙНЫМИ числами наш двумерный массив:
   ИСПОЛЬЗУЕМ ВСЁ ВЫШЕ и добавляем метод заполнения случайными числами, как в одномерном массиве (ранее решали)

int[,] matrix = new int[3, 4];

void PrintArray(int[,] matr) // этот метод PrintArray принимает в качестве аргументов двумерную таблицу чисел (int[,] и будет её печатать matrix
{
    for (int i = 0; i < matr.GetLength(0); i++)       // matrix.GetLength(0) = 3 для строк (о - это кол-во строк) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)   // matrix.GetLength(1) = 4 для столбцов (1 - это кол-во столбцов)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // после того как вывели столбцы через пробел, принудительно выводим на пустые строки - строки по i.
    }
}
void FillArray(int[,] matr)  // FillArray (заполнять массив) - это метод принимает в качестве аргументов двумерную таблицу чисел...
{
    for (int i = 0; i < matr.GetLength(0); i++)   // GetLength (получить длинну)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1; 10) - взяли полу интервал...
        }
    }
}
//int[,] matrix = new int[3, 4];      // !!! для удобства видимости, чтобы код был скомпанованым можно перетащить сверху....
PrintArray(matrix);                  // вызываем 1 , метод, где нолики - на печать, консоль...
FillArray(matrix);                  // вызываем заполнение 2 дополнительным методом, где случайные числа...
Console.WriteLine();               // добавим пустую строку для разделения 1 и 2 доп метода....
PrintArray(matrix);               // !обязательно вызываем печать по всем методам вместе.....
                                 // вызвали здесь два метода.............
*/
//ТИП ДАННЫХ(int)[,] НАИМЕНОВАНИЕ МАССИВА(matrix) = (ОПЕРАТОР ПРИСВАИВАНИЯ) new ТИП(int)[5, 8];

/*--------- ГДЕ МОЖНО ЕЩЁ ИСПОЛЗЬЗОВАТЬ ДВУМЕРНЫЕ МАССИВЫ---------*/

/*Как представить чёрно-белое изображение*/
/* 0 - ЗАКРАШЕННЫЙ ПИКСЕЛЬ, 1 ЭТО не ЗАКРАШЕННЫЙ ПИКСЕЛЬ --- ЗАДАЧКА КАК ЗАКРАСИТЬ ОБЛАСТЬ?*/
// Составляем Алгоритм: находим точку, которая находиться внутри закнутого круга, правила движения и обхода...

/*           |x-1,y|
    |x,y-1|  |  x,y|  |x,y+1|
             |x+1,y|             */

/* x - строка и движение по строке, y - столбец и движение по столбцу, в право и влево, вверх и вниз..
   можно двигаться и по диагонали, но тогда надо проверять дополнительные условия. Мы сейчас не будем.
   Договариваемя, что будем ходить сначало ВВЕРХ, ВЛЕВО, ВНИЗ, ВПРАВО. Пишем код:*/

/* == это знак совпадения*/

/* Метод 1. ниже, который выводит картинку нужную нам на консоль:

int[,] pic = new int[,]
{
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
// Этот метод 1 PrintImage принимает в качестве аргументов image двумерную таблицу чисел int[,]

void PrintImage(int[,] image) // image аргумент, Image(изображение) сделаем, чтобы печатались не нули и единицы, а более интересных вывод массива
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" "); // если совпадает с ноликом, то будем искусственно печатать пробел
            else Console.Write($"+"); // если нет, то +
        }
        Console.WriteLine();
    }
}
//int[,] pic = new int[,];
PrintImage(pic);            // вызвали метод на печать, консоль --- картинка
*/
/*
// Метод 2.(это метод 1 + метод2)  дополнительный, который заполняет картинку

int[,] pic = new int[,]
{
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
};
// Этот метод PrintImage принимает в качестве аргументов image двумерную таблицу чисел int[,]

// (int[,] image) - это метод возвращающий int[,] и в качестве аргумента принимающий image

void PrintImage(int[,] image) // image аргумент, Image(изображение) сделаем, чтобы печатались не нули и единицы, а более интересных вывод массива
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" "); // если совпадает с ноликом, то будем искусственно печатать пробел
            else Console.Write($"7"); // если нет, то +
        }
        Console.WriteLine();
    }
}
void FillImage(int ros, int col) // метод 2 доп - закраски...
{
    if (pic[ros, col] == 0)  // если наш пиксель(pic) совпадает с 0 (т.е не закрашен), то будем красить 1
    {
        pic[ros, col] = 1;  // красим 1     
        FillImage(ros - 1, col); // вызываем метод самого себя и определяем, что идёт за чем: ros строчка будет выше первое, затем:
        FillImage(ros, col - 1);
        FillImage(ros + 1, col);
        FillImage(ros - 1, col + 1);
    }
}
//int[,] pic = new int[,];
PrintImage(pic);            // вызвали метод на печать, консоль --- картинка
FillImage(16, 17);     // случайной точки укажем 13, 13
PrintImage(pic); 
*/
/*--------------------------------------------------------------------------------------------------*/

/*------------------------РЕКУРСИЯ:-----------------------------------------------------------------*/

/* В C# допускается, чтобы метод вызывал самого себя. Этот процесс называется рекурсией, а метод, вызывающий 
   самого себя, — рекурсивным. Вообще, рекурсия представляет собой процесс, в ходе которого нечто определяет 
   само себя. В этом отношении она чем-то напоминает циклическое определение. Рекурсивный метод отличается 
   главным образом тем, что он содержит оператор, в котором этот метод вызывает самого себя.  Реккурсия - это
   функция, которая вызывает сама себя.*/

// Задача: Решим факториал и напишем код 5! = 4*3*2*1, или 5! = 5*4!
//                                                                4*3! 
//                                                                  3*2! и т.д.
/* Задача: Напишем код (программу). Определить функцию или метод, которая будет принимать число, которое нужно 
   будет вычислить. Будет метод, который что-то принимает аргумент в частности это число и возвращает 
   факториал этого числа.*/
/*
// Вариант 1. метод с вызовом

int Factorial(int n)  // метод возвращающий int и в качестве аргумента принимает другое целое число.
{
    // 1!=1
    // 0!=1
    if (n == 1) return 1;        // дальше по определению факториала, если n совпадает с еденицей, то мы должны вернуть еденицу. Факториал числа n — это произведение всех натуральных чисел от 1 до n включительно. 
    else return n * Factorial(n-1); // 5!=5*4! если нет, то возвращаем значение: берём текущее значение * факториал предыдущего числа n-1/ 
}
Console.WriteLine(Factorial(3)); // 3!=3*2*1=6
*/

//Вариант 2. Метод с через For
/*
int Factorial(int n)  // метод возвращающий int и в качестве аргумента принимает другое целое число n.
{
    // 1!=1
    // 0!=1
    if (n == 1) return 1;        // дальше по определению факториала, если n совпадает с еденицей, то мы должны вернуть еденицу. Факториал числа n — это произведение всех натуральных чисел от 1 до n включительно. 
    else return n * Factorial(n-1); // 5!=5*4! если нет, то возвращаем значение: берём текущее значение * факториал предыдущего числа n-1/ 
}
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i)); // выведем факториал 40 и увидем, что в какой-то момент ТИП не позволяет считать числа.
    Console.WriteLine($"{i}! = {Factorial(i)}"); // попросим вывести удобно нам с интерполяциями строк.
}
*/
/*
//Вариант 3. Метод с через For. Так как тип int не позволяет считать факториал больше 19, поэтому нужно сменить тип.

double Factorial(double n)  // метод возвращающий int и в качестве аргумента принимает другое целое число.
{
    // 1!=1
    // 0!=1
    if (n == 1) return 1;        // дальше по определению факториала, если n совпадает с еденицей, то мы должны вернуть еденицу. Факториал числа n — это произведение всех натуральных чисел от 1 до n включительно. 
    else return n * Factorial(n-1); // 5!=5*4! если нет, то возвращаем значение: берём текущее значение * факториал предыдущего числа n-1/ 
}
for (double i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i)); // выведем факториал 40 и увидем, что в какой-то момент ТИП не позволяет считать числа.
    Console.WriteLine($"{i}! = {Factorial(i)}"); // попросим вывести удобно нам с интерполяциями строк.
}
*/

/* ----------------Ещё РЕКУРСИЯ------------------------------------*/

/* В математике числа Фибоначчи, обычно обозначаемые fn , образуют последовательность, последовательность Фибоначчи, 
   в которой каждое число является суммой двух предыдущих. 
   1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 */

/* Числа Фибоначчи могут быть определены рекуррентным соотношением: 
   F(0) = 0, 
   F(1) = 1,
   и 
   F(n) = F(n-1) + F(n-2) - это формула, при n>1.

Первые 20 чисел Фибоначчи Fn:
  F(n)= F0	F1	F2	F3	F4	F5	F6	F7	F8	F9	F10	F11	F12	F13	F14	F15	F16	 F17  F18   F19
         0   1	 1	 2	 3	 5	 8	13	21	34	 55	 89	144	233	377	610	987	1597 2584  4181 //F(n) = F(n-1) + F(n-2)   
  n =    0   1   2   3   4   5   6   7   8   9   10  11  12  13  14 . . .                19 . . .n    */

// F(1) = 1
// F(2) = 1
// F(n) = F(n-1) + F(n-2)
// == это равно, а = это оператор присваивания.
/*
//Метод Фибоначчи с int Фибоначчи

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1; // говорим, если значение n равно 1 или n равно 2, то возвращаем 1
    else return Fibonacci(n-1) + Fibonacci(n-2); // в противном случае
}
for (int i = 1; i < 100; i++)
{
    //Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"F{i} = F{i-1} + F{i-2} = {Fibonacci(i)}");
}
*/
/*
//Метод Фибоначчи с doble Фибоначчи

double Fibonacci(double n) 
{
    if(n == 1 || n == 2) return 1; // говорим, если значение n равно 1 или n равно 2, то возвращаем 1
    else return Fibonacci(n-1) + Fibonacci(n-2); // в противном случае
}
for (double i = 1; i < 30; i++)
{
    //Console.WriteLine(Fibonacci(i));
    Console.WriteLine($"F{i} = F{i-1} + F{i-2} = {Fibonacci(i)}");
}  
*/

/* Что же есть рекурсия?
 - Директо́рия (фр. directoire) — каталог, справочник, папка — объект в файловой системе, упрощающий организацию 
   файлов.
 - Как обойти директорию? Зайти в директорию. Обойти все директории внутри (обойти все папки внутри и показать 
   содержимое папок). Для этого надо изучить немного API.
 - API (МФА: [ˌeɪ.piˈaɪ]; аббр. от англ. Application Programming Interface[1]) — описание способов взаимодействия 
   одной компьютерной программы с другими. Обычно входит в описание какого-либо интернет-протокола (например, 
   SCIM[2]), программного каркаса (фреймворка[3]) или стандарта вызовов функций операционной системы[4]. 
   Часто реализуется отдельной программной библиотекой или сервисом операционной системы. Используется программистами 
   при написании всевозможных приложений. 
 - Проще говоря, это набор компонентов, с помощью которых компьютерная программа (бот или же сайт) может 
   использовать другую программу.
 - API (интерфейс прикладного программирования) упрощает процесс программирования при создании приложений, 
   абстрагируя базовую реализацию и предоставляя только объекты или действия, необходимые разработчику. Если 
   графический интерфейс для почтового клиента может предоставить пользователю кнопку, которая выполнит все шаги 
   для выборки и выделения новых писем, то API для ввода/вывода файлов может дать разработчику функцию, которая 
   копирует файл из одного места в другое, не требуя от разработчика понимания операций файловой системы, 
   происходящих за кулисами[5]. На семинаре 05 разберём. */

/* Двумерные массивы используются в игре в тетрис, где 0 это пусто, а где 1 закрашено.
   Движение фигуры это все напросто смещение этих еденичек и ноликов относительно друг друга. Это поворот 
   матрицы чисел. На семинаре 05 разберём. 
   Итоги:
   1. Циклов много не бывает и двумерные массивы тому подтверждение.
   2. Массивов много не бывает.
   3. Углубление в методы и практическая рекурсия.
   */
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
   по убыванию элементы каждой строки двумерного массива.
   Например, задан массив:
{1 4 7 2},
{5 9 2 3},
{8 4 2 4}
   В итоге получается вот такой массив:
{7 4 2 1},
{9 5 3 2},
{8 4 4 2}  */

//      Декомпозиция:
//  1. Метод ввода с клавиатуры строк и столбцов для двумерного массива.
//  2. Метод создания двумерного массива.
//  3. Метод заполнения двумерного массива случайными целыми числами.
//  4. Метод упорядочивания двумерного массива по убыванию.
//  5. Метод печати двумерного массива.
//  6. Вывод методов на экран.  

Console.Clear();

//  1. Метод ввода с клавиатуры количества строк и столбцов для двумерного массива.
void InputWithKeyboardsNumberRowsAndColumns(out int rows, out int columns)
{
    Console.Write("Введите количество строк: rows = ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: columns = ");
    columns = Convert.ToInt32(Console.ReadLine());
}

//  2.Метод создания двумерного массива.
void CreateArray2D(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
}

//  3. Метод заполнения двумерного массива случайными целыми числами.
void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив до изменения: ");
}

//  4. Метод упорядочивания двумерного массива по убыванию.

void ArrangeArray2DToDescending(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = 0;
                    temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями: ");
}

//  5. Метод печати двумерного массива. 
void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

//  6. Вывод методов на экран. 
int rows, columns;
InputWithKeyboardsNumberRowsAndColumns(out rows, out columns);

CreateArray2D(rows, columns);
int[,] matrix = new int[rows, columns];
FillArray2DRandomNumbers(matrix);
PrintArray2D(matrix);

ArrangeArray2DToDescending(matrix);

PrintArray2D(matrix);
/* Задача 50. Напишите программу, которая на вход принимает с клавиатуры двумерный массив mхn, а затем 
   возвращает значение элемента [m,n].
   Например, задан массив:
   1 4 7 2
   5 9 2 3
   8 4 2 4   => вернёт последнюю 4 */

Console.Clear();

void EnterCountRowsColumns(out int m, out int n)
{
    Console.Write("Введите количество строк m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов n: ");
    n = Convert.ToInt32(Console.ReadLine());
}

void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int PrintReturnValueElementEnteredToRowAndColumn(int[,] matr)
{
    int valueElement = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            valueElement = matr[matr.GetLength(1) - 1, matr.GetLength(1) - 1];
        }
    }
    Console.WriteLine($"Значение элемента в матрице valueElement[m,n] = {valueElement} ");
    return valueElement; // если в методе void, то без этой строки.
}


int m, n;
EnterCountRowsColumns(out m, out n);

int[,] numbers = new int[m, n];
FillArray2DRandomNumbers(numbers);

PrintArray2D(numbers);

PrintReturnValueElementEnteredToRowAndColumn(numbers);

/*
Console.Clear();

int[,] CreatArray2D(int m, int n)
{
    return new int[m,n];
}

void PrintArray2D(int[,] matr)
{
    int length0 = matr.GetLength(0);
    int length1 = matr.GetLength(1);
    
    for (int i = 0; i < length0; i++)
    {
        Console.Write($"[ ");
        for (int j = 0; j < length1; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.Write($"] ");
    Console.WriteLine();
    }       
}

void Fill2DArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }    
}    
int[,] matrix = CreatArray2D(5,5);
PrintArray2D(matrix);
Fill2DArrayRandomNumbers(matrix);
Console.WriteLine();
PrintArray2D(matrix);
*/

/* Задача: Инициализируйте двумерный массив* с именем arr2d заданными целочисленными значениями: 
   ((1, 2); (3, 4); (5, 6)). 
   1) Сначала выведите все элементы массива.
   2) После этого выведите следующие элементы в консоль (элементы для вывода отмечены синим цветом): => 3, 5 */


int[,] arr2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}


void PrintArray2DElements(int[,] arr)
{
    Console.WriteLine($"element1 = {arr[1, 0]} и element2 = {arr[2, 0]} ");
}

PrintArray2D(arr2D);
PrintArray2DElements(arr2D);



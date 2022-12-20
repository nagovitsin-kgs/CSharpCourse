/* Задача: Инициализируйте двумерный массив* с именем arr2d заданными целочисленными значениями: 
   ((1, 2); (3, 4); (5, 6)). 
   1) Сначала выведите все элементы массива.
   2) После этого выведите следующие элементы в консоль (элементы для вывода отмечены синим цветом): => 3, 5 */

int[,] arr2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

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
Console.WriteLine();
}
Console.WriteLine();

void PrintArray2DElements(int[,] arr)
{
    Console.WriteLine($"element1 = {arr[1, 0]} и element2 = {arr[2, 0]} ");
}

PrintArray2D(arr2d);
PrintArray2DElements(arr2d);
Console.WriteLine();

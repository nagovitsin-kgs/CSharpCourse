/* Задача 62: Заполните спирально массив 4 на 4. */

Console.Clear();

Console.Write("Введите размерность квадратного массива: size = ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    matrix[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(matrix);

void PrintArray(int[,] array)
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
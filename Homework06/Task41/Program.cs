// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// 1. Ввод пользователем с клавиатуры числа в диапазоне от - M до M, через запятую.
Console.WriteLine("Введите числа через запятую:");
string numbers = Console.ReadLine();

// 2. Создаём массив из строки от пользователя.
string[] newNumbers = new string[numbers.Length];

// 3. Проверяем строку на пробелы и запятые.
int k = 0;

for (int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',' || numbers[i] == ' ')
    {
        k++;
    }
    else
    {
        newNumbers[k] = newNumbers[k] + $"{numbers[i]}";
    }
}
k++;

// 4. Создаём массив из целых проверенных строчных чисел.
int[] resultNumbers = new int[k];

// 5. Метод. Печать массива с преобразованием в целые числа.
void PrintArray(int[] array, string[] string1)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1[i]);
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

// 6. Вывод результата.
PrintArray(resultNumbers, newNumbers);
int sum = 0;

for (int i = 0; i < k; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + sum);


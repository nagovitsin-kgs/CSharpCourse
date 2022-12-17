/* Задача 38: Задайте массив вещественных чисел. 
   Найдите разницу между максимальным и минимальным элементов массива.
   [3 7 22 2 78] -> 76 */

/* Вещественные числа – типы: float (число с одинарной точностью) и double (число с двойной точностью) – 
   в переменных данных типов могут хранится только вещественные числа (числа с плавающей точкой). 
   Десятичные числа, а именно тип decimal – данный тип позволяет сохранять число без потери точности, 
   как оно было передано в переменную таким и останется (в отличии от типов float и double, где может 
   произойти округление). */

// Создание массива:
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");

PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
// --- Методы:---
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
/*Задайте одномерный массив, заполненный случайными числами. 
  Найдите сумму элементов, стоящих на нечетных позициях.
  [3, 7, 23, 12] => 19
  [-4, -6, 89, 6] => 0 */

// Создание массива:

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

// --- Функции, методы: ---

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
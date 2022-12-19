// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 1. Ввод пользователем с клавиатуры.
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
 
// 2. Ложим в переменные x,y значения выведенные из уравнения. 
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

// 3. Выводим x,y  
x = Math.Round(x, 3);
y = Math.Round(y, 3);

// 4. Вывод на консоль результата.
Console.WriteLine($"Пересечение в точке: ({x};{y})");

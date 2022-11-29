// Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

//  4 -> да 
// -3 -> нет 
//  7 -> нет 

Console.WriteLine("Start");

int number; 

            Console.Write("Введите число : ");
 
            number = int.Parse(Console.ReadLine());
 
            if (number % 2 == 0)
 
            {
 
                Console.Write("Введенное число является четным");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("Введенное число нечетное");
 
                Console.Read();
            }

Console.WriteLine("End");
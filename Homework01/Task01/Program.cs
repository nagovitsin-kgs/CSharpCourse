﻿Console.WriteLine("Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел");

Console.WriteLine("Start");   // Start

int a = 2;   // ввели переменую a 
int b = 3;   // ввели переменую b
int c = 7;   // ввели переменую c

int max = a; // ввели переменую max = a, приняли, что она равна максимальному значению а

if (b > max) max = b; //если условие выполняется, то b становится максимальным
if (c > max) max = c; //если условие выполняется, то c становиться максимальным

Console.WriteLine(max); //вывод максимального значения

Console.WriteLine("End"); // окончание
﻿/*
using ClassLibrary; // нужно прописать пространство имён, в рамках которого находиться наш класс (смотри в файле MyLogic)

// тут работа будет, сначала будет копилироваться библитотека ClassLibrary, а затем файлы которые получили будут подкладываться в папку ConsoleApp (по ней правой кнопкой и показать в проводнике)

var l = new MyLogic(); // создаём переменную l, в нею ложим наш метод из библиотеки пишем имя new MyLogic
l.Pause();             // вызываем наш метод и магия в терминале)))...

// Либо можно так:
// MyLogic l = new(); // в переменную l имя()
// l.Pause();         // вызываем метод.
*/      

// ---- Всё выше удаляем якобы и заново:-----

using ClassLibrary;   // наша библиотека

namespace ConsoleApp;                 // пространство имён можно своё в С# вот так базовое название, как и наш проект, папка


class Program
{
    static void Main(string[] args)  // статик - точка входа...
    {
        MyLogic l = new();  // в рамках этого метода описываем логику
        l.Pause();          // вызываем.   
    }
}






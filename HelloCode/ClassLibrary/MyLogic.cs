namespace ClassLibrary;       // пространство имён, наша папка (библиотека).
using static System.Console;  // ввели, чтобы сократить команды, не писать систем и консоле.

public class MyLogic          // указали паблик класс и файл MyLogic // где описываем нвшу логику, методы...
{
    public void Pause()
    {
        WriteLine("Автор я");
        ReadKey();
    }
}

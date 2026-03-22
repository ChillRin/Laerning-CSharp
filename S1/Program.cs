using System;

namespace LerninS1;

class Progrma
{
    static void Main(string[] args)
    {
        //S1.1. Вывести на экран число  с точностью до сотых.
        //S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
        //S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
        //S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

        float floatingNumber = 1.23f;
        Console.WriteLine("S1.1 - " + floatingNumber);

        double e = Math.E;
        // Умножаем на 10 (27.18...), усекаем (27), делим на 10 (2.7)
        e = Math.Truncate(e * 10) / 10;
        Console.WriteLine("S1.2 - " + e);

        Console.Write("S1.3/4 - Введите любое число >> ");
        string userInput = Console.ReadLine();
        Console.WriteLine("S1.3 - Вы ввели число >> " + userInput);
        Console.WriteLine("S1.4 - " + userInput + " — вот какое число Вы  ввели");
    }
}
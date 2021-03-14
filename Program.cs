using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;     //Православие для консоли (поддержка киррилицы)
            Console.WriteLine("Ку друг!");                          // вывод текста
            Console.Write("Введи метры: ");                         //
            float metri = Convert.ToInt32(Console.ReadLine());      // запись ввода в переменную с плавающей точкой
            Console.WriteLine($"Вот в км: {metri/1000}");           // вывод текста и перевод переменной в км

            Console.WriteLine("\nНажмите любую клавишу для выхода.");//чтобы приложение сразу не закрывалось
            Console.ReadKey();
        }
    }
}

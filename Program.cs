
using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace lab5
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите путь к текстовому файлу: ");
            string Path = Console.ReadLine();
            OhWords.FixFile(Path);
            Console.WriteLine("файл исправлен\n");
            Console.ReadKey();
        }
    }
}
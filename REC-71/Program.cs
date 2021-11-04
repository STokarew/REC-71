using System;
using System.Text.RegularExpressions;
namespace REC_71

{
    class Program
    {
        static string CleanString(string strIn)
        {
            return Regex.Replace(strIn, @"[\W*]", "");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Console.WriteLine($"Результирующая строка: {CleanString(Console.ReadLine())}");
            Console.ReadLine();

        }
    }
}

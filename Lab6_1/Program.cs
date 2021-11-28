using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение самого длинного слова в строке.");
            Console.WriteLine("Введите с клавиатуры предложение:");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string max = string.Empty;
                      
            foreach (string s in stringArray)
            {
                if (s.Length>max.Length)
                max = s;
                
            }
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}

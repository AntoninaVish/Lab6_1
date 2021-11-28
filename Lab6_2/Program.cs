using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определяем является ли строка палиндромом.");
            Console.WriteLine("Введите с клавиатуры предложение:");
            string startString = Console.ReadLine();
            char[] obrString = startString.ToCharArray();
            Array.Reverse(obrString);
            string newString = new string(obrString);
            string[] stringArray = startString.Split();
            string[] newstringArray = newString.Split();
            string resultString = "";
            string finalString = "";
            foreach (string s in stringArray)
            {
                resultString += s.ToLower();

            } 
            foreach (string s in newstringArray)
            {
                finalString += s.ToLower();
            }
 

            if (finalString == resultString)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadKey();

        }
    }
}

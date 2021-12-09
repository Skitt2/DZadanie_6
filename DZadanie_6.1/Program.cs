using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZadanie_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int lengthWord;
            int maxLength = 0;
            string longWord = "";
            foreach (string s in stringArray)
            {
                lengthWord = s.Length;
                if (lengthWord > maxLength)
                {
                    maxLength = lengthWord;
                    longWord = s;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении \"{0}\" ", longWord);
            Console.ReadKey();
        }
    }
}

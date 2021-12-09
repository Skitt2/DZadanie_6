using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZadanie_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string resultString = "";
            string reverseString = "";
            for (int i = 0; i < stringArray.Length; i++)
            {
                resultString += stringArray[i];
            }
            //Console.WriteLine(resultString);
            for (int j = resultString.Length - 1; j >= 0; j--)
            {
                reverseString += resultString[j];
            }
            //Console.WriteLine(reverseString);
            if (String.Compare(resultString, reverseString, true) == 0)
            {
                Console.WriteLine("Cтрока является палиндромом");
            }
            else
            {
                Console.WriteLine("Cтрока не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}

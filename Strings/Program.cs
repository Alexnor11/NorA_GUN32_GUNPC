﻿using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Strings
{
    internal class Program
    {
        // Задание 1
        // Напишите метод, который принимает две строки и возвращает конкатенацию этих строк.
        static void ConcatenateStrings(string firstString, string secondString)
        {
            Console.WriteLine($"Конкатенация строк: {string.Concat(firstString, " ", secondString)}");
        }

        // Втрой вариант
        //static void Concatenate()
        //{
        //    Console.WriteLine("Введите первую строку: ");
        //    var firstString = Console.ReadLine();

        //    Console.WriteLine("Введите вторую строку: ");
        //    var secondString = Console.ReadLine();

        //    Console.WriteLine($"Concat: {string.Concat(firstString," ",secondString)}");
        //}


        // Задание 2
        // Напишите метод GreetUser, который получает имя(string) и возраст(int)
        private static void GreetUser(string userName, int userAge)
        {
            Console.WriteLine($"Hello, {userName}!\nYou are {userAge} years old.");
        }

        // Втрой вариант
        //private static void GreetUserNew()
        //{
        //    Console.WriteLine("Введите имя пользователя:");
        //    var userName = Console.ReadLine();

        //    Console.WriteLine("Введите возраст пользователя:");
        //    var userAge = Console.ReadLine();

        //    Console.WriteLine($"Hello, {userName}!\nYou are {userAge} You are.");
        //}

        // Задание 3
        private static void InfoString()
        {
            string print = new String('*', 15);

            Console.WriteLine(print);
            string info = "плохой день";

            Console.WriteLine($"Старая строка: {info}");
            Console.WriteLine($"Колличество строк: {info.Length}");

            Console.WriteLine(print);
            info = info.Replace("плохой", "хороший");
            Console.WriteLine($"Новая строка: {info}");
            Console.WriteLine($"Колличество строк: {info.Length}");


            Console.WriteLine(print);
            Console.WriteLine($"Вверхний регистр {info.ToUpper()}");
            Console.WriteLine($"Нижний регистр {info.ToLower()}");
        }

        //Задание 4
        private static void SymbolString(string str)
        {
            Console.WriteLine($"Строка целиком: {str}");
            Console.WriteLine($"Первые 5 символов строки: {str.Substring(0, 5)}");
        }

        // Задание 5 (два варианта)
        // Первый вариант
        private static void StringToBilder()
            
        {            
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Название: "); 
            sb.Append(" Руководство");
            sb.Append(" по C#");
            Console.WriteLine(sb.ToString());

            Console.WriteLine($"Длина: {sb.Length}");
            Console.WriteLine($"Емкость: {sb.Capacity}");
        }
        // Втрой вариант 
        private static void StringToBilderNew(string[] strings)
        {
            foreach( string i in strings)
            {
                //Console.Write(i);
                StringBuilder sb = new StringBuilder();
                sb.Append(i);
                sb.Append(" ");
                Console.Write(sb.ToString());                
            }
            Console.WriteLine();
            
        }
        // Задание 6
        public static void ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            string text = inputString;
            text = text.Replace(wordToReplace, replacementWord);
            Console.WriteLine(text);

        }


        static void Main(string[] args)
        {
            //Concatenate();
            //GreetUserNew();
            
            ConcatenateStrings("Hello", "World");
            Console.WriteLine(new String('*', 15));
            
            GreetUser("Alexey", 38);
           
            InfoString();

            Console.WriteLine(new String('*', 15));
            SymbolString("Замечательный");

            Console.WriteLine(new String('*', 15));
            StringToBilder();

            Console.WriteLine(new String('*', 15));
            string[] arr = { "Название:", "Руководство", "по C#" };
            StringToBilderNew(arr);

            Console.WriteLine(new String('*', 15));
            ReplaceWords("Hello world", "world", "universe");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework5
{
    class Answer
    {
        public void Answer1A()
        {
            Console.WriteLine("\n  Answer1\n");

            Homework tw = new Homework();
            if (tw.CheckLogin("d123"))
                Console.WriteLine("Ваш логин соответствует требованиям!");
            else
                Console.WriteLine("Ваш логин не соответствует требованиям!");

            Console.ReadKey();
        }

        public void Answer1B()
        {
            Homework test = new Homework();

            if (test.CheckLoginRegular("dddddddddddfdddf"))
            {
                Console.WriteLine("Ваш логин соответствует требованиям!");
            }
            else
            {
                Console.WriteLine("Ваш логин не соответствует требованиям!");
            }
                

            Console.ReadKey();
        }

        public void Answer2()
        {
            StreamWriter file = new StreamWriter("Answer2.txt");

            Console.WriteLine("Привет, сейчас будет тест моих методов :)");
            file.WriteLine("Привет, сейчас будет тест моих методов :)");
            Console.WriteLine("Введи предложение, чем длиннее - тем лучше");
            string data = Console.ReadLine();
            file.WriteLine($"Твоё предложение: {data}");
            Console.WriteLine("а) Вывести только те слова сообщения, которые содержат не более n букв.");
            file.WriteLine("а) Вывести только те слова сообщения, которые содержат не более n букв.");
            Console.WriteLine("Введи n");
            int n = Convert.ToInt32(Console.ReadLine());
            file.WriteLine($"Твоё n: {data}");
            Console.WriteLine("Ответ: ");
            file.WriteLine("Ответ: ");
            Message.MaxCharInString(data, n, file);
            Console.WriteLine(" ");
            file.WriteLine(" ");


            Console.WriteLine("б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            file.WriteLine("б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            Console.WriteLine("Введи символ");
            char ch = Convert.ToChar(Console.ReadLine());
            file.WriteLine($"Твой символ: {ch}");
            Console.WriteLine("Ответ: ");
            file.WriteLine("Ответ: ");
            Message.DeleteWordLastChar(data,ch,file);
            Console.WriteLine(" ");
            file.WriteLine(" ");


            Console.WriteLine("в) Найти самое длинное слово сообщения.");
            file.WriteLine("в) Найти самое длинное слово сообщения.");
            Console.WriteLine("Ответ: ");
            file.WriteLine("Ответ: ");
            Message.MaxWord(data, file);
            Console.WriteLine(" ");
            file.WriteLine(" ");


            Console.WriteLine("г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            file.WriteLine("г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            Console.WriteLine("Ответ: ");
            file.WriteLine("Ответ: ");
            Message.StringFromMaxWords(data,file);
            Console.WriteLine(" ");
            file.WriteLine(" ");


            file.Flush();
            file.Close();
        }

        public void Answer3()
        {
            Permutation g = new Permutation();
            string text1, text2;
            Console.WriteLine("  Answer3\n");
            Console.WriteLine("Введите 2 текста подряд:");
            text1 = Console.ReadLine();
            text2 = Console.ReadLine();
            g.String(text1, text2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Answer test = new Answer();

            //test.Answer1B();
            //test.Answer2();

            //test.Answer3();

            Permutation asd = new Permutation();
            asd.String("abc", "abc");

            Console.ReadKey();
        }
    }
}
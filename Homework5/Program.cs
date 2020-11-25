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

            Console.WriteLine("Напишите ваш логин: ");
            string login = Console.ReadLine();

            if (tw.CheckLogin(login))
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

        public void Answer4()
        {
            Console.WriteLine("  Answer5 \n");
            Console.WriteLine("Введите количество учеников: (не меньше 10 и  не больше 100)");
            int n = Convert.ToInt32(Console.ReadLine());
            string student;

            double min = 5;
            School_97[] students = new School_97[n];

            if (n > 0 && n < 100)
            {

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Вводите: ");
                    student = Console.ReadLine();
                    string[] arrSplit = student.Split(' ');

                    while (Convert.ToInt32(arrSplit[2]) < 1 || Convert.ToInt32(arrSplit[2]) > 5 || Convert.ToInt32(arrSplit[3]) < 1 || Convert.ToInt32(arrSplit[3]) > 5 || Convert.ToInt32(arrSplit[4]) < 1 || Convert.ToInt32(arrSplit[4]) > 5)
                    {
                        Console.WriteLine("Введите ученика еще раз с корректными оценками!");
                        student = Console.ReadLine();
                        arrSplit = student.Split(' ');
                    }

                    students[i] = new School_97(arrSplit[0], arrSplit[1], Convert.ToInt32(arrSplit[2]), Convert.ToInt32(arrSplit[3]), Convert.ToInt32(arrSplit[4]));
                }

                Program.Sort(n, ref students);

                for (int i = 0; i < n - 1; i++)
                {
                    if (i < 3 || (students[2].AVG() == students[i + 1].AVG()))
                    {
                        students[i].Print();
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы не правы!");
            }
        }

        public void Answer5()
        {
            Console.WriteLine("  Answer5\n");
            HomeWork5 test2 = new HomeWork5();
            test2.ReadFile("TrueOrFalse.txt");
        }
    }
    class Program
    {
        static public void Sort(int SIZE, ref School_97[] first)
        {
            for (int i = 0; i < SIZE - 1; i++)
            {
                for (int j = 0; j < SIZE - 1; j++)
                {
                    if (first[j].AVG() > first[j + 1].AVG())
                    {
                        School_97 temp = first[j];
                        first[j] = first[j + 1];
                        first[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
             Answer test = new Answer();

            test.Answer1A();
            test.Answer2();
            test.Answer3();
            test.Answer4();
            test.Answer5();

            Console.ReadKey();
        }
    }
}
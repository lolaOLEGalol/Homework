using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Homework5
{
    class Homework
    {
        public bool CheckLogin (string userLogin) // 1A
        {
            for (int i = 0; i < userLogin.Length; i++)
            {
                if (userLogin[i] > 'z' || userLogin[i] < 'a' && !(userLogin[i] >= '0' && userLogin[i] <= '9'))
                {
                    return false;
                }
            }
                if ((userLogin[0] >= '0' && userLogin[0] <= '9') || userLogin.Length < 3 || userLogin.Length > 10)
                {
                    return false;
                }

                else
                    return true;
        }

        public bool CheckLoginRegular (string userLogin)
        {
            string regMask = @"^\D[a-zA-Z0-9]{2,8}$";
            Regex rg = new Regex(regMask);

            return rg.IsMatch(userLogin);
        } // 1B
    }

    static class Message
    {

        public static void MaxCharInString (string data, int maxChar, StreamWriter file)
        {
            string[] arr = data.Split(' ');

            foreach (string s in arr)
            {
                if(s.Length < maxChar)
                {
                    Console.WriteLine(s);
                    file.WriteLine(s);
                }
            }
        }

        public static void DeleteWordLastChar (string data, char ch, StreamWriter file)
        {
            string[] arr = data.Split(' ');
            
            foreach (string s1 in arr)
            {
                char simvol = s1[s1.Length - 1];
                if (simvol != ch)
                {
                    Console.WriteLine(s1);
                    file.WriteLine(s1);
                }
            }
        }

        public static void MaxWord (string data, StreamWriter file)
        {
            string[] arr = data.Split(' ');
            int max = arr[0].Length;
            string Word = arr[0];

            foreach (string s in arr)
            {
                if (s.Length > max)
                {
                    Word = s;
                    max = s.Length;
                }
            }

            Console.WriteLine(Word);
            file.WriteLine(Word);
        }

        public static void StringFromMaxWords (string data, StreamWriter file)
        {
            string[] arr = data.Split(' ');
            int max = arr[0].Length;
            string Word = arr[0];

            StringBuilder build = new StringBuilder();

            foreach (string s in arr)
            {
                if (s.Length > max)
                {
                    max = s.Length;
                }
            }

            foreach (string s in arr)
            {
                if (s.Length == max)
                {
                    build.Append($"{s} ");
                }
            }

            Console.WriteLine(build);
            file.WriteLine(build);
        }
    } // 2

    class Permutation
    {
        public void String(string text1, string text2)
        {
            int a = string.Compare(text1, text2);
            Console.WriteLine(a);
        } // 3A

        public void String2(string text1, string text2)
        {
            bool check;
            check = text1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(text2.Select(Char.ToUpper).OrderBy(x => x));

            if (check)
            {
                Console.WriteLine("Текст является перестановкой другого текста");
            }
            else
            {
                Console.WriteLine("Тексты отличаются");
            }

            Console.ReadKey();
        } //3B
    }

    class School_97
    {
        private string _family;
        private string _name;
        private int _mark1, _mark2, _mark3;

        public void SetFamily (string family)
        {
            _family = family;
        }

        public void SetName (string name)
        {
            _name = name;
        }

        public void SetMark (int mark1, int mark2, int mark3)
        {
            _mark1 = mark1;
            _mark2 = mark2;
            _mark3 = mark3;
        }

        public School_97 (string family, string name, int mark1, int mark2, int mark3)
        {
            if (family.Length < 20)
            {
                _family = family;
            }
            else
            {
                Console.WriteLine("Фамилия содержит больше 20 символов");
            }

            if (name.Length < 15)
            {
                _name = name;
            }
            else
            {
                Console.WriteLine("Имя содержит больше 15 символов");
            }

            if ((mark1 < 6 && mark1 > 0) || (mark2 < 6 && mark2 > 0) || (mark3 < 6 && mark3 > 0))
            {
                _mark1 = mark1;
                _mark2 = mark2;
                _mark3 = mark3;
            }
            else
            {
                Console.WriteLine("Одна из оценок не из 5-бальной с.с. ");
            }
        }

        public void Print ()
        {
            Console.WriteLine($"Фамилия: {_family}");
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"{AVG()}");
        }

        public double AVG ()
        {
            return (_mark1 + _mark2 + _mark3) / 3;
        }

        public void Foooooo()
        {
            Console.WriteLine($"{_family} {_name} {AVG()}");
        }
    }

    class HomeWork5
    {
        Random rnd = new Random();
        public void WriteFile(string path)
        {
            StreamWriter tt = new StreamWriter(path, false, Encoding.UTF8);
            tt.WriteLine("Наебал?\nда\nСтул или собака?\nнет\nХуй в жопу или палец?\nда\nИдешь на работу?\nнет\nУчишься ?\nда\nОлег лох?\nда\nРома лох?\nнет\nЛох лох?\nда\nКакой?\nда\nВилкой в глаз или в жопу раз?\nнет");
            tt.Flush();
            tt.Close();
        }
        public void ReadFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string[] questions = new string[20];

            for (int i = 0; i < 20; i++)
            {
                questions[i] = sr.ReadLine();
            }
            string Answer;
            int score = 0;

            int[] checkIndex = new int[10];
            int trigger = 0;


            for (int i = 0; i < 5; i++)
            {
                int temp = Convert.ToInt32(rnd.Next(0, 19));

                for (int j = 0; j < 10; j++)
                {
                    if (temp != checkIndex[j])
                    {
                        trigger++;
                    }
                }

                if (temp % 2 == 0 && trigger == 10)
                {
                    Console.WriteLine(questions[temp]);
                    checkIndex[i] = temp;
                    Answer = Console.ReadLine();
                    if (Answer == questions[temp + 1])
                    {
                        score++;
                        Console.WriteLine("Верно");
                    }
                }
                else if (temp % 2 == 1 && trigger == 10)
                {
                    i--;
                }
                else if (trigger != 10)
                {
                    i--;
                    //Console.WriteLine("ТРИГЕР НЕ РАВЕН 10!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                }
                trigger = 0;
                
            }
            Console.WriteLine($"Мы ответили верно на {score} вопросов");
        }
    }

}

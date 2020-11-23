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

}

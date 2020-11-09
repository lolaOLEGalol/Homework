using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class classHomework
    {

        public int countMin(int Number1, int Number2, int Number3)
        {
            int min = Number1;
            if (min > Number2)
            {
                min = Number2;
            }
            if (min > Number3)
            {
                min = Number3;
            }
            return min;
        }

        public int countNumber(int Number)
        {
            int k = 0;
            while (Number % 10 > 0)
            {
                Number = Number / 10;
                k++;
            }
                
            return k;
        }

        public void summOddNumber()
        {
            Print("Программа для вывода суммы нечетных чисел. Пишите числа, чтобы закончить - пишите 0");
            int summ = 0;
            int Number = -1;

            while (Number != 0)
            {
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number > 0 && Number%2 == 1)
                {
                    summ += Number;
                }
            }

            Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
        }

        public bool password()
        {
            Print("Чтобы продолжить необходимо авторизироваться");

            string login = "root" , userLogin;
            string password = "GeekBrains", userPassword;
            int k = 0;

            do
            {
                k++;
                Console.WriteLine($"---Попытка №{k}");
                Print("Введите логин: ");
                userLogin = Console.ReadLine();
                Print("Введите пароль: ");
                userPassword = Console.ReadLine();
            }
            while ((userPassword != password || userLogin != login) && k < 3);

            if (userLogin == login && userPassword == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Print("\nДобро пожаловать, Роман!\n");
                return true;
            } else
            {
                Print("Хакерам не пройти!");
                return false;
            }
        }

        public void sportBody()
        {
            double mass, h, ideal;
            Print("Программа для определения: стоит ли Вам похудеть или набрать массу.");
            Print("Пожалуйста, введите свой вес: ");
            mass = Convert.ToDouble(Console.ReadLine());
            Print("Пожалуйста, введите свой рост: ");
            h = Convert.ToDouble(Console.ReadLine());
            
            ideal = (h-100) * 1.15;

            if ((mass - 1)> ideal)
            {
                Print($"Вам стоит сбросить {mass - ideal}кг");
            }
            else if ((mass + 1) < ideal)
            {
                Print($"Вам стоит набрать {ideal - mass}кг");
            }
            else 
            {
                Print("Вы слишком афигенный, Вам не стоит ничего с собой делать :)");
            }
        }

        private int summNumbers(int i)
        {
            int summ = 0;
            while (i % 10 > 0)
            {
                i = i / 10;
                summ += i;
            }
            if (summ == 0)
            {
                summ = 1;
            }

            return summ;
        }
        public void goodNumbers(int R)
        {
            DateTime start = DateTime.Now;
            int k = 0;
            for(int i = 1; i < R; i++)
            {
                if (i % summNumbers(i) == 0)
                {
                    k++;
                }
            }
            DateTime finish = DateTime.Now;
            double time = (finish - start).TotalSeconds;
            Print($"Простых чисел {k}/{R}");
            Print($"Времени было затрачено {time} с.");
        }

        public void recurseCountNumber (int min, int max)
        {
            if (min != max+1)
            {
                Console.WriteLine($"{min}; ");
                min++;
                recurseCountNumber(min, max);
            }
        }

        public void recurseSumm (int a, int b, int summ)
        {
            if (a < b+1)
            {
                summ += a;
                a++;
                recurseSumm(a, b, summ);
            }
            else if (a == b+1)
            {
                Print(summ);
            }

        }

        public void Pause()
        {
            Console.ReadKey();
        }

        public void Print(int a)
        {
            Console.WriteLine(a);
        }

        public void Print(string a)
        {
            Console.WriteLine(a);
        }
    }
}

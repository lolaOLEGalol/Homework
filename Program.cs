using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        class Answer
        {
            public void Answer1()
            {
                Console.WriteLine("  Answer 1\n\nСоздать массив из 20 элементов, заполнить от -10000 до 10000 и\nвывести количество пар, где хотя бы 1 элемент делится на 3\n\nИсходный массив:");
                int size = 20, k;
                HelpArr test = new HelpArr();
                int[] arr = new int[size];

                arr = test.RandomArr(size, -10000, 10000);
                test.PrintArr(arr, size);
                k = test.CountCouple(arr, size);
                Console.WriteLine($"\nКоличество пар, где хотя бы 1 элемент делится на 3 = {k}");
                test.Pause();
            }

            public void Answer2()
            {
                int size = 5;
                int[] arr = new int[size];
                HelpArr my = new HelpArr();
                Console.WriteLine("\n  Answer 2\n");

                Console.WriteLine("\nНачальный массив ---------");
                arr = my.RandomArr(size, 0, 100);
                my.PrintArr(arr, size);
                Console.WriteLine("\nМассив под инверсией -----");
                arr = my.Invers(arr, size);
                my.PrintArr(arr, size);
                Console.WriteLine("\nМассив умноженный на 2 ---");
                arr = my.Multi(arr, size, 2);
                my.PrintArr(arr, size);
                my.MaxCount(arr, size);
                int k = my.GetMaxCount();
                Console.WriteLine($"\nКоличество максимальных чисел: {k}");

                Console.ReadKey();
            }

            public void Answer2B()
            {
                HelpArr test = new HelpArr();
                int[] arr = new int[100];

                for (int i = 0; i < 100; i++)
                {
                    arr[i] = i + 1;
                }

                test.FileWrite("st.cs", 1020);
                test.FileRead("st.cs");

                Console.ReadKey();
            }

            public void Answer3()
            {
                Account user = new Account();

                string userLogin, userPassword;
                Console.WriteLine("\n  Answer 3\n\n");
                Console.WriteLine("Пожалуйста, задайте логин: ");
                userLogin = Console.ReadLine();
                Console.WriteLine("Пожалуйста, задайте пароль: ");
                userPassword = Console.ReadLine();

                user.SetLoginAndPassword(userLogin, userPassword);

                Console.WriteLine("\nОтлично, они сохранились в файле Account.txt :) Теперь попробуйте их ввести!");
                while(true)
                {
                    Console.WriteLine("\nЛогин: ");
                    userLogin = Console.ReadLine();
                    Console.WriteLine("Пароль: ");
                    userPassword = Console.ReadLine();

                    if (user.CheckLoginAndPassword(userLogin, userPassword))
                    {
                        Console.WriteLine("\nВы вошли в систему!");
                        break;
                    }
                    else if (userLogin == "1" && userPassword == "1")
                    {
                        Console.WriteLine("\nВы досрочно вышли из системы. Удачи!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nЛогин или пароль не верны.Попробуйте еще раз!");
                        Console.WriteLine("Чтобы выйти досрочно в поле логин и пароль введите 1");
                    }

                }

                Console.ReadKey();
            }

            public void Answer4()
            {
                Console.WriteLine("\n  Answer 4\nЧтобы увидеть массив раскомментируйте 112 строчку");
                HelpTwoArr ar = new HelpTwoArr();
                //ar.Print();
                Console.WriteLine($" Сумма: {ar.Summ()}");
                Console.WriteLine($" Сумма от 50: {ar.Summ(50)}");
                Console.WriteLine($" Максимальный элемент массива: {ar.GetMaxElement()}");
                Console.WriteLine($" Минимальный элемент массива: {ar.GetMinElement()}");

                HelpTwoArr ar2 = new HelpTwoArr("tee2.txt");

                Console.ReadKey();
            }
        }


        static void Main(string[] args)
        {
            Answer hw = new Answer();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Чтобы переключиться на следующее задание тыкайте на любую клавишу! :)\n");

            hw.Answer1();
            hw.Answer2();
            hw.Answer3();
            hw.Answer4();

            Console.ReadKey();
        }
    }
}

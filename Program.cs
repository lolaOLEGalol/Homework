using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Answer
    {
        public void Answer1()
        {
            Complex first = new Complex();
            Complex second = new Complex();
            Complex result = new Complex();

            first.imaginary = 30;
            second.imaginary = 4;
            first.real = 2;
            second.real = 2;

            Console.WriteLine(string.Format("Answer1\n"));

            result = first.Multi(second);
            Console.WriteLine($"{result.imaginary} , {result.real} (Multi)\n------------");

            result = first.Division(second);
            Console.WriteLine($"{result.imaginary} , {result.real} (Division)\n------------");

            result = first.Subtraction(second);
            Console.WriteLine($"{result.imaginary} , {result.real} (Subtraction)\n------------");

            result = first.Summ(second);
            Console.WriteLine($"{result.imaginary} , {result.real} (Summ)\n------------");
        }

        public void Answer2()
        {
            Console.WriteLine("\n\nAnswer 2\n");
            Homework3 test2 = new Homework3();
            Console.WriteLine($"Пожалуйста, введите числа, чтобы посчитать суммы нечетных положительных чисел. \nДля остановки программы напишите 0.\n");
            test2.summOddNumber();
        }

        public void Answer3()
        {
            Console.WriteLine("\n\nAnswer 3\n");

            Double test = new Double(), test2 = new Double();
            
            Console.WriteLine("Введите числитель и знаменатель 1й дроби:");
            test.numerator = Convert.ToInt32(Console.ReadLine());
            test.denominator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите числитель и знаменатель 2й дроби:");
            test2.numerator = Convert.ToInt32(Console.ReadLine());
            test2.denominator = Convert.ToInt32(Console.ReadLine());

            if (test.denominator == 0 || test2.denominator == 0)
            {
                Console.WriteLine("Вы ввели знаменталь = 0!");
            }
            else
            {
                Console.WriteLine($"{test.Summ(test2):0.00} - сумма дробей \n{test.Subtraction(test2):0.00} - разность дробей \n{test.Multi(test2):0.00} - перемножение дробей \n{test.Division(test2):0.00} - деление дробей");
            }
        }

        public void Answer3Fixed()
        {
            DoubleFixed test = new DoubleFixed();
            DoubleFixed test2 = new DoubleFixed();

            Console.WriteLine("\nВведите числитель и знаменатель 1й дроби:");
            test.numerator = Convert.ToInt32(Console.ReadLine());
            test.denominator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите числитель и знаменатель 2й дроби:");
            test2.numerator = Convert.ToInt32(Console.ReadLine());
            test2.denominator = Convert.ToInt32(Console.ReadLine());

            test.Summ(test2); test.Subtraction(test2); test.Division(test2); test.Multi(test2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Answer test = new Answer();

            test.Answer1();
            test.Answer2();
            test.Answer3();
            test.Answer3Fixed();

            Console.ReadKey();
        }
    }
}

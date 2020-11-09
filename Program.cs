using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            classHomework test = new classHomework();
            Console.ForegroundColor = ConsoleColor.Red;
            

            if (test.password())
            {
                Console.ForegroundColor = ConsoleColor.White;
                test.Print("\nЗадача 1\nНайти минимальное число из 3х:");
                test.Print(test.countMin(16, 5, 9));
                    test.Pause();
                test.Print("\nЗадача 2\nПосчитать количество цифр в числе:");
                test.Print(test.countNumber(358));
                    test.Pause();
                test.Print("\nЗадача 3");
                test.summOddNumber();
                    test.Pause();
                test.Print("\nЗадача 5");
                test.sportBody();
                    test.Pause();
                test.Print("\nЗадача 6");
                test.Print("Идет загрузка. Примерное время для обработки 1 млрд. составляет 78 сек.");
                test.goodNumbers(100);
                    test.Pause();
                test.Print("\nЗадача 7");
                test.recurseCountNumber(2, 10);
                test.Print("\nСумма чисел:");
                test.recurseSumm(2, 10, 0);
                    test.Pause();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            test.Print("\n\nЗадание выполнил студент GeekBrains, Нахаев Олег\n");
            test.Pause();
        }
    }
}

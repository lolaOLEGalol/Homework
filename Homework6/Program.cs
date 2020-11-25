using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    using System;
    public delegate double Fun(double x, double a);
    
    class Answer
    {
        public void Answer1()
        {
            Class1 test = new Class1();
            Console.WriteLine($" Answer1\n");

            test.Table(test.MyFunc, 3, 2);
            test.Table(test.Sin, 2, 2);
            Console.ReadKey();
        }

        public void Answer2()
        {
            Console.WriteLine("  Answer2\n");
            Console.WriteLine("Смотрите код в Class2");
        }
       
        public void Answer3()
        {
            Console.WriteLine("Некоректное задание без CSV файла");
        }

    }

    class Program
    { 
        static void Main()
        {
            Answer temp = new Answer();
            //temp.Answer1();
            //temp.Answer2();

            //Answer gg = new Answer();
            Console.ReadKey();
            
        }
    }

}

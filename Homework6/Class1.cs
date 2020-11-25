using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

delegate void Print();


namespace Homework6
{
    
    class Class1
    {
        public void Table(Fun F, double x, double a)
        {
            Console.WriteLine($"{F(x, a):0.00}");
            Console.WriteLine($"-----------");
        }
        public double MyFunc(double x, double a)
        {
            return x * x * a;
        }

        public double Sin(double x, double a)
        {
            return Math.Sin(x) * a;
        }
    }

    class Class2
    {

        public delegate double Del(double x);
        public Del [] Test;
        public double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public double F2(double x)
        {
            return x * x - 50 * x + 100;
        }
        public double F3(double x)
        {
            return x * x - 50 * x + 1000;
        }
        public void SaveFunc(Del Foo, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Foo(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public double []Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[]temp = new double[fs.Length/sizeof(double)];

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                temp[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return temp;
        }
          public void SSS()
        {
            Console.WriteLine("Выберете функцию F1, F2, или F3\nЧтобы выбрать F1 - 1, F2 - 2, F3 - 3");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Test[0] = F1;
            }
            else if (a == 2)
            {
                Test[0] = F2;
            }
            else if (a == 3)
            {
                Test[0] = F3;
            }
            else
            {
                Console.WriteLine("Вы ввели не то число");
            }

            double tempMin;
            SaveFunc(Test[0], "data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin", out tempMin));
            Console.ReadKey();
        }
    }

    class Class3
    {
        private int bakalavr;
        private int magistr;
        public void Foo()
        {
            int numOfBachelors = 0;
            int numOfMasters = 0;
            // Создадим необобщенный список
            ArrayList list = new ArrayList();
            // Запомним время в начале обработки данных
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("..\\..\\students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                    list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                    if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v);
            // Вычислим время обработки данных
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }

    } // Нет csv, не знаю как делать без нее. + задания написаны очень не понятно,что нужно делать.
}


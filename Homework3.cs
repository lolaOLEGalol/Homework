using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    struct Complex
    {
        public double imaginary;
        public double real;

        public Complex Multi(Complex x)
        {
            Complex multi;
            multi.imaginary = imaginary * x.imaginary;
            multi.real = real * x.real;
            return multi;
        }

        public Complex Summ(Complex x)
        {
            Complex summ;
            summ.imaginary = imaginary + x.imaginary;
            summ.real = real + x.real;
            return summ;
        }

        public Complex Subtraction(Complex x)
        {
            Complex subtraction;
            subtraction.imaginary = imaginary - x.imaginary;
            subtraction.real = real - x.imaginary;
            return subtraction;
        }

        public Complex Division(Complex x)
        {
            Complex division;
            division.imaginary = imaginary / x.imaginary;
            division.real = real / x.real;
            return division;
        }
    }
    class Homework3
    {
        public void summOddNumber()
        {
            int summ = 0;
            int Number = -1;
            string temp;
            bool check = true;



            while (Number != 0 || !check)
            {
                temp = Console.ReadLine();
                check = int.TryParse(temp, out Number);

                if (check)
                {
                    if (Number > 0 && Number % 2 == 1)
                    {
                        summ += Number;
                    }
                }
                else
                {
                    Console.WriteLine($"Вы ввели: {temp}, пожалуйста, введите число еще раз");
                }

            }
            Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
        }
    }
    class Double
    {
        public double numerator; //числитель
        public double denominator; // знаменатель

        public double Summ(Double other)
        {
            return (numerator / denominator) + (other.numerator / other.denominator);
        }

        public double Subtraction(Double other)
        {
            return (numerator / denominator) - (other.numerator / other.denominator);
        }

        public double Multi(Double other)
        {
            return (numerator / denominator) * (other.numerator / other.denominator);
        }

        public double Division(Double other)
        {
            return (numerator / denominator) / (other.numerator / other.denominator);
        }
    }

    class DoubleFixed
    {
        public int numerator; 
        public int denominator;

        public void Summ(DoubleFixed other)
        {
            Console.WriteLine($"{numerator*other.denominator + other.numerator*denominator} | {denominator*other.denominator}");
        }

        public void Subtraction(DoubleFixed other)
        {
            Console.WriteLine($"{numerator * other.denominator - other.numerator * denominator} | {denominator * other.denominator}");
        }

        public void Multi(DoubleFixed other)
        {
            Console.WriteLine($"{numerator*other.numerator} | {denominator*other.denominator}");
        }

        public void Division(DoubleFixed other)
        {
            Console.WriteLine($"{numerator*other.denominator} | {denominator*other.numerator}");
        }
    }
   
}

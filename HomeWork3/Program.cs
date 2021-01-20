using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    /// <summary>
    /// Класc для комплексных чисел
    /// </summary>
    class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = this.re * x2.re - this.im * x2.im;
            x3.im = this.re * x2.im + this.im * x2.re;
            
            return x3;
        }
        public override string ToString()
        {
            string zn;
            double _im = 0;
            if (im >= 0)
            {
                zn = " + ";
                _im = im;
            }
            else
            {
                zn = " - ";
                _im = -im;
            }

            return re + zn + ((_im != 0) ? "" + _im : "" ) + "i";
        }
    }

    /// <summary>
    /// Структура для комплексных чисел
    /// </summary>
    struct SComplex
    {
        public double im;
        public double re;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Структура комплексного числа</returns>
        public SComplex Plus(SComplex x)
        {
            SComplex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns>Структура комплексного числа</returns>
        public SComplex Minus(SComplex x)
        {
            SComplex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Структура комплексного числа</returns>
        public SComplex Multi(SComplex x)
        {
            SComplex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            string zn;
            double _im = 0;
            if (im >= 0)
            {
                zn = " + ";
                _im = im;
            }
            else
            {
                zn = " - ";
                _im = -im;
            }

            return re + zn + ((_im != 0) ? "" + _im : "") + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            /*
             1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
                б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса; 
            */
            Complex complex1 = new Complex();
            complex1.re = 3;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = -3;

            Console.WriteLine("Класс"); 

            Console.WriteLine("Первое комплексное число: {0}", complex1.ToString());
            Console.WriteLine("Второе комплексное число: {0}", complex2.ToString());

            Complex result1 = complex1.Plus(complex2);
            Console.WriteLine("Результат cложения комплексных чисел: {0}", result1.ToString());

            Complex result2 = complex1.Minus(complex2);
            Console.WriteLine("Результат вычитания комплексных чисел: {0}", result2.ToString());

            Complex result3 = complex1.Multi(complex2);
            Console.WriteLine("Результат умножения комплексных чисел: {0}", result3.ToString());

            Console.WriteLine();

            SComplex scomplex1;
            scomplex1.re = 2;
            scomplex1.im = 4;

            SComplex scomplex2;
            scomplex2.re = -1;
            scomplex2.im = 2;

            Console.WriteLine("Структура");

            Console.WriteLine("Первое комплексное число: {0}", scomplex1.ToString());
            Console.WriteLine("Второе комплексное число: {0}", scomplex2.ToString());

            SComplex sresult1 = scomplex1.Plus(scomplex2);
            Console.WriteLine("Результат cложения комплексных чисел: {0}", sresult1.ToString());

            SComplex sresult2 = scomplex1.Minus(scomplex2);
            Console.WriteLine("Результат вычитания комплексных чисел: {0}", sresult2.ToString());

            SComplex sresult3 = scomplex1.Multi(scomplex2);
            Console.WriteLine("Результат умножения комплексных чисел: {0}", sresult3.ToString());

            Console.ReadKey();
            #endregion
        }
    }
}

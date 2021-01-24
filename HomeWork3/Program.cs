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

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns>Комплексное число</returns>
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        /// <summary>
        /// Разность комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns>Комплексное число</returns>
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="x2"></param>
        /// <returns>Комплексное число</returns>
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.re = this.re * x2.re - this.im * x2.im;
            x3.im = this.re * x2.im + this.im * x2.re;
            
            return x3;
        }

        /// <summary>
        /// Вывод комплексного числа в строку
        /// </summary>
        /// <returns>Строка</returns>
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

    class Fraction
    {
        public double num;
        public double den;

        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Наибольший общий делитель</returns>
        static double GCD(double a, double b)
        {
            if (a < 0)
                a = -a;
            if (b < 0)
                b = -b;
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public Fraction()
        {

        }

        /// <summary>
        /// Дробь
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="den">Знаменатель</param>
        public Fraction(double num, double den)
        {
            if (den <= 0)
                throw new ArgumentException("Знаменатель не может быть меньше 0");
            this.num = num;
            this.den = den;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="b"></param>
        /// <returns>Дробь</returns>
        public Fraction Plus(Fraction b)
        {
            var cn = this.num * b.den + this.den * b.num;
            var cd = this.den * b.den;
            var _GCD = GCD(cn, cd);
            Fraction c = new Fraction(cn/_GCD, cd/_GCD);
            return c;
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="b"></param>
        /// <returns>Дробь</returns>
        public Fraction Minus(Fraction b)
        {
            var cn = this.num * b.den + this.den * -b.num;
            var cd = this.den * b.den;
            var _GCD = GCD(cn, cd);
            Fraction c = new Fraction(cn / _GCD, cd / _GCD);
            return c;
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="b"></param>
        /// <returns>Дробь</returns>
        public Fraction Multi(Fraction b)
        {
            var cn = this.num * b.num;
            var cd = this.den * b.den;
            var _GCD = GCD(cn, cd);
            Fraction c = new Fraction(cn / _GCD, cd / _GCD);
            return c;
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="b"></param>
        /// <returns>Дробь</returns>
        public Fraction Div(Fraction b)
        {
            var cn = this.num * b.den;
            var cd = this.den * b.num;
            if (cd < 0)
            {
                cn = -cn;
                cd = -cd;
            }
            var _GCD = GCD(cn, cd);
            Fraction c = new Fraction(cn / _GCD, cd / _GCD);
            return c;
        }

        /// <summary>
        /// Вывод дроби в строку
        /// </summary>
        /// <returns>Строка</returns>
        public override string ToString()
        {
            if (this.den == 1)
                return "" + this.num;
            else
                return "" + this.num + "/" + this.den;
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

            #region Задание 2
            /*
            2.  а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
                б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. При возникновении ошибки вывести сообщение. Напишите соответствующую функцию
            */

            Console.Clear();
            Console.WriteLine("Вводите числа. Для окончания введите 0.");
            int i = -1;
            int s = 0;
            do
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    if (i > 0 && i % 2 > 0)
                        s = s + i;
                }
                else
                {
                    Console.WriteLine("Введено не верное число. Требуется ввод целого числа.");
                    i = -1;
                }
            while (i != 0);
            Console.WriteLine($"Сумма положительных нечетных чисел равна {s}");
            Console.ReadKey();
            #endregion

            #region Задание 3
            /*
            3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
            Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            Написать программу, демонстрирующую все разработанные элементы класса.
            */

            Console.Clear();
            var a = new Fraction(1, 2);
            var b = new Fraction(2, 3);
            var c1 = a.Plus(b);
            Console.WriteLine($"Результат сложения дробей {a} и {b} равна {c1}");
            var c2 = a.Minus(b);
            Console.WriteLine($"Результат вычитания дробей {a} и {b} равна {c2}");
            var c3 = a.Multi(b);
            Console.WriteLine($"Результат умножения дробей {a} и {b} равна {c3}");
            var c4 = a.Div(b);
            Console.WriteLine($"Результат деления дробей {a} и {b} равна {c4}");
            Console.ReadKey();

            #endregion
        }
    }
}

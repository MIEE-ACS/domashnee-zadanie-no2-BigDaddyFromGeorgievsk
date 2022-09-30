using System;
using System.Globalization;

namespace HomeWork_2
{
    //Variant 6 Karapetov Valery
    class Program
    {


        static double Segment1(double x)
        {
            return -3;
        }

        static double Segment2(double x)
        {
            return x + 3;
        }

        static double Segment3(double x, double r)
        {
            double a = 0;
            double b = 0;
            double y = Math.Sqrt(r * r - (x - a) * (x - a)) + b; //окружность с центром в (0;0)

            return y;
        }

        static double Segment4(double x)
        {
            return 0.6 * x - 1.8;
        }
        static double Segment5(double x)
        {
            return 3;
        }
        static void Main(string[] args)
        {
            Console.Write("Таблица со всеми точками функции:\n");

            for (double x = -8; x <= 10.1; x += 0.2)
            {
                if (x < -8)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if ((x >= -8) && (x < -4.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                if ((x > -5.1) && (x <= -2.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                }
                if ((x >= -3.1) && (x < 2.9))
                {

                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x, 3));

                }
                if ((x > 3.1) && (x <= 7.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }
                if ((x > 8.1) && (x < 9.9))
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                }
            }
            double r;
            Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.Write("Введите радиус в численном виде:");
            }

            if (r < 3) r = 0;

            while (true)
            {
                Console.Write("Введите аргумент функции: ");
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Введите аргумент функции в численном виде:");
                }

                if (x < -8)
                {
                    Console.WriteLine("Функция не определена");
                }

                if (x == -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                
                else if (x < -5)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment1(x));
                }
                else if (x < -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment2(x));
                }
                else if (x < 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment3(x, r));
                }
                else if (x < 8)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment4(x));
                }

                else if (x <= 10)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, Segment5(x));
                }
                else
                {
                    Console.WriteLine("Функция не определена");
                }

            }
        }
    }
}

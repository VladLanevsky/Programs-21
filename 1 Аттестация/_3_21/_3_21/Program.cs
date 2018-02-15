using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_21
{
    class Program
    {
        static bool IsPointInParabola(double x, double y)
        {
            return y < -0.0625 * Math.Pow((x - 6), 2) - 6;
        }

        static bool IsPointInHorizontalParabola(double x, double y, double y0, double x0, double a) // Проверяет,находится ли точка внутри параболы с заданными коэффициентами 

        {
            return x > a * Math.Pow((y - y0), 2) + x0; // Math.Pow(x,a) - функция возведения в степень 

        }

        static bool IsPointAboveHorizontalParabola(double x, double y, double y0, double x0, double a)
        {
            return y > y0 + Math.Sqrt((x - x0) / a);
        }

        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a) // Проверяет,находится ли точка выше прямой,парметры которой переданы в функцию 
        {
            return y > a * (x - x0) + y0;
        }

        static bool IsPointInRectangle(double x, double y, double x0, double y0, double x1, double y1)
        {
            bool a = x > x0 && x < x1;
            bool b = y > y0 && y < y1;
            return a && b;
        }



        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) < Math.Pow(r, 2);
        }
        enum SimpleColor
        {
            Black,
            White,
            Gray,
            Red,
            Orange,
            Yellow,
            Green,
            Blue
        }
        static SimpleColor GetColor(double x, double y) // Основной метод программы,определяющий цвет по заданной координате 
        {

            if ((IsPointInCircle(x, y, -2, 5, 4) && IsPointInCircle(x, y, -3, 7, 2)) ||
            (!IsPointAboveLine(x, y, 0, -19, 4) && IsPointInHorizontalParabola(x, y, 3, 5, 1)))

                return SimpleColor.Blue; // Если выполнены условия,то вернёт Синий 

            if ((IsPointInCircle(x, y, 1, -4, 4) && IsPointAboveLine(x, y, 0, -19, 4)) ||
            (IsPointInCircle(x, y, -3, 7, 2) && !IsPointInCircle(x, y, -2, 5, 4)))
                return SimpleColor.Green; // Если выполнены условия,то вернёт Зелёный 

            if ((IsPointAboveLine(x, y, 0, -19, 4) && !IsPointInCircle(x, y, 1, -4, 4) && !IsPointInCircle(x, y, -3, 7, 2) &&
            !IsPointInCircle(x, y, -2, 5, 4)) || (!IsPointAboveLine(x, y, 0, -19, 4) && IsPointInCircle(x, y, 1, -4, 4)) ||
            (!IsPointAboveLine(x, y, 0, -19, 4) && IsPointAboveHorizontalParabola(x, y, 3, 5, 1)))

                return SimpleColor.Yellow; // Если выполнены условия,то вернёт Желтый 

            return SimpleColor.Gray; // Если ни один из цветов не подходит, то вернёт Серый 

        }
        static void Main(string[] args)
        {
            double x, y;
            for (; ; ) // цикл для заполнения координат
            {
                try
                {
                    Console.WriteLine("Введите координату Х: ");
                    x = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату Y: ");
                    y = Double.Parse(Console.ReadLine());
                    if (x < 10 && x > -10 && y < 10 && y > -10)
                    {
                        Console.WriteLine("(" + x + ";" + y + ") —>" + GetColor(x, y));
                    }
                    else
                    { Console.WriteLine("Числа не лежат в границах от -10 до 10. Повторите ввод"); }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Вы ввели буквы,повторите ввод");
                }


            }
            Console.ReadKey();
        }
    }
}
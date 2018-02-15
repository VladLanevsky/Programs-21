using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_83_21
{
    class Program
    {
        static bool IsPointInParabola(double x, double y)
        {
            return y > 0.125 * Math.Pow((x + 2), 2) - 5;
        }



        static bool IsPointAboveLine(double x, double y, double x0, double y0, double a) // Проверяет,находится ли точка выше
        {                                                                                // прямой,парметры которой переданы в функцию
            return y > a * (x - x0) + y0;
        }


        static bool IsPointRightOfParabola(double x, double y)
        {
            return x > -2 + Math.Sqrt((y + 5) / 0.125);
        }


        static bool IsPointInCircle(double x, double y, double x0, double y0, double r)
        {
            return Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) < Math.Pow(r, 2);
        }
        enum SimpleColor
        { Black, White, Gray, Red, Orange, Yellow, Green, Blue }
        static SimpleColor GetColor(double x, double y) // Основной метод программы,определяющий цвет по заданной координате
        {

            if ((!IsPointInParabola(x, y) && IsPointAboveLine(x, y, 0, 2.75, 0.25) && !IsPointRightOfParabola(x, y)) ||
                (IsPointInCircle(x, y, -1, -6, 2) && !IsPointInParabola(x, y)))


                return SimpleColor.Yellow; // Если выполнены условия,то вернёт Серый

            if ((IsPointRightOfParabola(x, y) && !IsPointInParabola(x, y) && IsPointAboveLine(x, y, 0, 2.75, 0.25)) ||
                (!IsPointAboveLine(x, y, 0, 2.75, 0.25) && !IsPointRightOfParabola(x, y) && !IsPointInParabola(x, y) && IsPointAboveLine(x, y, 0, -3, 0)))


                return SimpleColor.Blue; // Если выполнены условия,то вернёт Синий

            if ((IsPointInParabola(x, y) && IsPointAboveLine(x, y, 0, 2.75, 0.25) && !IsPointAboveLine(x, y, 1, 0, -4)) ||
                (IsPointInCircle(x, y, -1, -6, 2) && IsPointInParabola(x, y)))

                return SimpleColor.Orange; // Если выполнены условия,то вернёт Оранжевый

            if (!IsPointAboveLine(x, y, 0, 2.75, 0.25) && IsPointAboveLine(x, y, 1, 0, -4) && IsPointAboveLine(x, y, 0, -3, 0))

                return SimpleColor.White; // Если выполнены условия,то вернёт Оранжевый

            if ((IsPointAboveLine(x, y, 1, 0, -4) && !IsPointAboveLine(x, y, 0, -3, 0)) ||
                (IsPointAboveLine(x, y, 0, 2.75, 0.25) && IsPointAboveLine(x, y, 1, 0, -4) && IsPointInParabola(x, y)))

                return SimpleColor.Gray; // Если выполнены условия,то вернёт Оранжевый

            return SimpleColor.Green; // Если ни один из цветов не подходит, то вернёт Серый

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

                Console.ReadKey();
               
            }
        }
            
        }
    }


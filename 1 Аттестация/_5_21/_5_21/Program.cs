using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void PrintFunc(int w, int h)
        {


            int k = (w - 2) / 2;
            int l = 1;
            int r = 1;
            string zvezd = null;
            string space = null;
            string ob = null;

            for (int m = 0; m < k; m++)
            {
                zvezd += "*";
                ob += "-" + "-";
                space += " ";

            }
            int i = 0;
            int j = 0;
            Console.WriteLine("+" + ob + "+");
            while (i < (h - 2))
            {


                if (i % 2 == 0)
                {

                    for (int p = 0; p < l; p++)
                    {
                        if (j < (h - 2)) { }
                        else break;
                        Console.WriteLine("|" + zvezd + space + "|");
                        j++;

                    }
                    l++;
                }

                else
                {

                    for (int p = 0; p < r; p++)
                    {
                        if (j < (h - 2)) { }
                        else break;
                        Console.WriteLine("|" + space + zvezd + "|");
                        j++;

                    }
                    r++;
                }
                i++;
                System.Threading.Thread.Sleep(100);

            }
            Console.WriteLine("+" + ob + "+");

        }
        static void Main(string[] args)
        {
            int w, h;
            int flag = 1;
            while (flag == 1)
            {
                for (; ; )
                {



                    try
                    {
                        Console.WriteLine("Введите ширину фигуры W: ");
                        w = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Введите высоту фигуры H: ");
                        h = Int32.Parse(Console.ReadLine());
                        if ((w >= 2) && (w % 2 == 0) && h >= 2)
                        {
                            PrintFunc(w, h);
                        }
                        else
                        { Console.WriteLine("Числа не удовлетворяют условиям. Повторите ввод"); }
                    }
                    catch (FormatException exception)
                    {
                        Console.WriteLine("Вы ввели буквы,повторите ввод");
                    }

                    Console.WriteLine("если хотите закрыть программу, введите 0");
                    flag = Int32.Parse(Console.ReadLine());
                    if (flag == 0)
                    {
                        break;
                    }
                }



                Console.ReadKey();
            }
        }

    }
}


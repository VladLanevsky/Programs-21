using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Summ(int N)
        {
            double sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(i, (N - i) + 1);
            }
            Console.WriteLine("Сумма равна: " + sum);
        }
        static void Main(string[] args)
        {
            int N;
            try
            { 
            Console.WriteLine("Введите число слагаемых: ");
            N = Int32.Parse(Console.ReadLine());
                Summ(N);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Вы ввели буквы,повторите ввод");
            }
            
        
            Console.ReadKey();
        
        }
    }
}
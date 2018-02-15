using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class ArrayTls
    {
        public int[] Arr { get; set; }
        public ArrayTls(int[] Arr)
        {
            this.Arr = Arr;
        }
        private int FirstSeriesCount()//кол-во элементов в первой серии
        {
            int count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == Arr[0])
                    count++;
                else
                    break;
            }
            return count;
        }
        private int LastSeriesCount()//кол-во элементов в последней серии
        {
            int count = 1;
            for (int i = Arr.Length - 2; i >= 0; i--)
            {
                if (Arr[i] == Arr[Arr.Length - 1])
                    count++;
                else
                    break;
            }
            return count;
        }
        private bool FindSeriesK(int k, out int index, out int count)//поиск K-ой серии
        {
            int series = 1;
            index = 0;
            count = 1;
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] == Arr[index])
                    count++;
                else
                {
                    if (series == k)
                        return true;
                    series++;
                    index = i;
                    count = 1;
                }
            }
            if (series == k)
                return true;
            return false;
        }
        public int[] SwapFirstAndK(int k)// меняет местами 1ую и K-ую серию 
        {
            if (FindSeriesK(k, out int index, out int Kcount))
            {
                if (index == 0)
                    return Arr;
                int Fcount = FirstSeriesCount();
                int[] ArrNew = new int[Arr.Length];
                Array.Copy(Arr, index, ArrNew, 0, Kcount);
                Array.Copy(Arr, Fcount, ArrNew, Kcount, index - Fcount);
                Array.Copy(Arr, 0, ArrNew, Kcount + index - Fcount, Fcount);
                Array.Copy(Arr, Kcount + index, ArrNew, Kcount + index, Arr.Length - Kcount - index);
                return ArrNew;
            }
            else
                return Arr;
        }
        public int[] SwapLastAndK(int k)// меняет местами последнюю и K-ую серию 
        {
            if (FindSeriesK(k, out int index, out int Kcount))
            {
                if (index + Kcount == Arr.Length)
                    return Arr;
                int Lcount = LastSeriesCount();
                int[] ArrNew = new int[Arr.Length];
                Array.Copy(Arr, ArrNew, index);
                Array.Copy(Arr, Arr.Length - Lcount, ArrNew, index, Lcount);
                Array.Copy(Arr, index + Kcount, ArrNew, index + Lcount, Arr.Length - Lcount - index - Kcount);
                Array.Copy(Arr, index, ArrNew, Arr.Length - Kcount, Kcount);
                return ArrNew;
            }
            else
                return Arr;
        }
        int GetCount(int Value)//считает кол-во элементов в массиве 
        {
            int count = 0;
            foreach (int item in Arr)
                if (item == Value)
                    count++;
            return count;
        }
        public int GetIndexOfFrequent() //поиск второго с конца, частого элемента
        {
            int Value = Arr[0];
            int Count = GetCount(Value);
            int CountT = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                CountT = GetCount(Arr[i]);
                if (CountT > Count)
                {
                    Count = CountT;
                    Value = Arr[i];
                }
                else if (CountT == Count && (Math.Abs(Arr[i]) > Math.Abs(Value) || Math.Abs(Arr[i]) > Math.Abs(Value) && Arr[i] > Value))
                    Value = Arr[i];
            }
            bool t = false;
            for (int i = Arr.Length-1; i >= 0; i--)
                if(Arr[i] == Value)
                {
                    if (t) return i;
                    else t = true;
                }
            return -1;
        }
    }
}

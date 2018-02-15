using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsLibrary
{
    public class IntMatrix
    {
        public int[,] Matrix { get; set; }
        public IntMatrix(int[,] Matrix)
        {
            this.Matrix = Matrix;
        }
        private int GetRowSum(int Row) // Сумма строки 
        {
            int sum = 0;
            for (int i = 0; i < Matrix.GetLength(1); i++)
                sum += Matrix[Row, i];
            return sum;
        }
        private void GetMinAndMaxRow(out int Min, out int Max)//поиск минимальной и максимальной строки
        {
            Min = 0;
            Max = 0;
            int MinValue = GetRowSum(0);
            int MaxValue = MinValue;
            int Value = 0;
            for (int i = 1; i < Matrix.GetLength(0); i++)
            {
                Value = GetRowSum(i);
                if (Value > MaxValue)
                {
                    Max = i;
                    MaxValue = Value;
                }
                if (Value < MinValue)
                {
                    Min = i;
                    MinValue = Value;
                }
            }
        } 
        public int[] GetArr() //выделение массива
        {
            if (Matrix.GetLength(0) != Matrix.GetLength(0))
                throw new Exception("матрица не квадратная");
            GetMinAndMaxRow(out int Min, out int Max);
            int[] Arr = new int[Matrix.GetLength(0) * 2];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Arr[2 * i] = Matrix[Min, i];
                Arr[2 * i + 1] = Matrix[Max, i];
            }
            return Arr;
        }
    }
}

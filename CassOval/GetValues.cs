// GetValues.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using System;
using System.Windows.Forms;

namespace CassOval
{
    public class GetValues
    {
        public static double GetY(double x, double a, double c)
        {
            a = Math.Pow(a, 4);
            c = Math.Pow(c, 2);
            x = Math.Pow(x, 2);

            double y = Math.Sqrt(Math.Sqrt(a + 4 * c * x) - x - c);

            return y;
        }

        internal static void FillArrays(double[] arrOfX, double[] arrOfY, DataGridView dataTable)
        {
            int column = 0;
            int row    = 0;

            for (int i = 0; i < arrOfX.Length; i++)
            {
                arrOfX[i] = (double)dataTable[column, row].Value;
                column++;
                arrOfY[i] = (double)dataTable[column, row].Value;
                column--;
                row++;
            }
        }
    }
}

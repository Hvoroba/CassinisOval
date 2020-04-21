// AllTests.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using System;
using System.Windows.Forms;

namespace CassOval
{
    class AllTests
    {
        internal static bool GoodToGo(double lb, double rb, double step)
        {
            if (ValidInput() && AllFieldsFilled() && ValidBorders(lb, rb, step))
            {
                return true;
            }
            return false;
        }

        internal static bool AllFieldsFilled()
        {
            for (int i = 1; i < (int)CassiniOval.TextBoxes.CoefB; i++)
            {
                string tempStr = Enum.GetName(typeof(CassiniOval.TextBoxes), i) + "_tb";

                if (Form.ActiveForm.Controls[tempStr].Text.Length == 0)
                {
                    MessageBox.Show("Заполните все поля", "Ошибка");
                    return false;
                }
            }

            return true;

        }

        internal static bool ValidBorders(double lb, double rb, double step)
        {
            if (step <= 0)
            {
                MessageBox.Show("Неправильный ввод шага!");
                return false;
            }

            if (rb - step < lb)
            {
                MessageBox.Show("Неправильный ввод шага и/или границ!");
                return false;
            }

            if ((rb - lb) / step > 10000.0)
            {
                MessageBox.Show("Промежуток сликшом большой!");
                return false;
            }

            return true;
        }

        internal static bool FuncCheck(double lb, double rb, double step, double coefA, double coefC)
        {
            DialogResult DR = new DialogResult();
            int errCounter = 0;

            for (double i = lb; i <= rb; i += step)
            {
                double x = i;
                double y = GetValues.GetY(x, coefA, coefC);

                if (Double.IsNaN(y))
                {
                    errCounter++;
                }
            }

            if (errCounter != 0)
            {
                DR = MessageBox.Show("При таких значениях часть функции под корнем отрицательно. Не будет отображено точек: " + errCounter
                    + ". Продолжить?", "Внимание!", MessageBoxButtons.OKCancel);
                if (DR == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }

        internal static bool ValuesFit(double[] arrOfY, double lb, double rb)
        {
            int notFittingElements = 0;

            for (int i = 0; i < arrOfY.Length; i++)
            {
                if (arrOfY[i] < -rb || arrOfY[i] > rb)
                {
                    notFittingElements++;
                }
            }

            if (notFittingElements != 0)
            {
                DialogResult DR = new DialogResult();

                DR = MessageBox.Show("В указанный промежуток не входит точек: " + notFittingElements + ". Продолжить?",
                    "Внимание!", MessageBoxButtons.OKCancel);

                if (DR == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }

        internal static bool ValidInput()
        {
            for (int i = 1; i < (int)CassiniOval.TextBoxes.CoefB; i++)
            {
                string tempStr = Enum.GetName(typeof(CassiniOval.TextBoxes), i) + "_tb";

                double.TryParse(Form.ActiveForm.Controls[tempStr].Text, out double num);

                if (num == 0 && Form.ActiveForm.Controls[tempStr].Text != "0")
                {
                    MessageBox.Show("Неправильный ввод!");
                    return false;
                }
            }

            return true;
        }
    }
}

// Configurate.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using System;

namespace CassOval
{
    class Configurate
    {
        internal static void ChangeBG()
        {
            if (CassiniOval.ActiveForm.BackgroundImage.Height == Properties.Resources.first.Height)
            {
                CassiniOval.ActiveForm.BackgroundImage = Properties.Resources.second;
            }
            else if (CassiniOval.ActiveForm.BackgroundImage.Height == Properties.Resources.second.Height)
            {
                CassiniOval.ActiveForm.BackgroundImage = Properties.Resources.first;
            }
        }

        internal static double ToFixed(double number, uint decimals)
        {
            string str =  number.ToString("N" + decimals);

            return Convert.ToDouble(str);
        }
    }
}

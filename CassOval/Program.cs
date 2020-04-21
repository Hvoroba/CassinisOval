// Program.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using System;
using System.Windows.Forms;

namespace CassOval
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CassiniOval());
        }
    }
}

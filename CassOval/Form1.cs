// CassiniOval.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using System;
using System.Linq;  
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CassOval
{
    public partial class CassiniOval : Form
    {
        internal enum Symbols
        {
            Backspace = 8
        }

        internal enum TextBoxes
        {
            LeftBorder = 1,
            RightBorder,
            Step,
            CoefA,
            CoefB
        }

        internal enum DecimalPlaces
        {
            ForY = 4
        }

        public CassiniOval()
        {
            InitializeComponent();
        }

        internal void ConfigurateChart(double lb, double rb, double[] arrOfY)
        {

            CassiniChart.ChartAreas[0].AxisX.Minimum = lb;
            CassiniChart.ChartAreas[0].AxisY.Minimum = Math.Floor(arrOfY.Min());

            CassiniChart.ChartAreas[0].AxisX.Maximum = rb;
            CassiniChart.ChartAreas[0].AxisY.Maximum = Math.Ceiling(arrOfY.Max());

        }

        private void build_button_MouseClick(object sender, MouseEventArgs e)
        {
            dataTable.Rows.Clear();

            Configurate.ChangeBG();

            CassiniChart.Series[0].Points.Clear();
            CassiniChart.Series[1].Points.Clear();

            double.TryParse(leftBorder_tb.Text, out double lb);
            double.TryParse(rightBorder_tb.Text, out double rb);
            double.TryParse(step_tb.Text, out double step);
            double.TryParse(coefA_tb.Text, out double a);
            double.TryParse(coefC_tb.Text, out double c);
            double x;
            double y;

            if (AllTests.GoodToGo(lb, rb, step) && AllTests.FuncCheck(lb, rb, step, a, c))
            {
                int size = Convert.ToInt32(Math.Abs((rb - lb) / step + 1));

                double[] arrOfY = new double[size * 2];

                int indexCounter = 0;

                for (double i = lb; i <= rb; i += step)
                {
                    x = i;
                    y = GetValues.GetY(x, a, c);
                    CassiniChart.Series[0].Points.AddXY(x, y);
                    CassiniChart.Series[1].Points.AddXY(x, -y);
                    arrOfY[indexCounter] = y;
                    indexCounter++;
                    arrOfY[indexCounter] = -y;
                    indexCounter++;
                    if (!Double.IsNaN(y))
                    {
                        // округление до 4 знаков после запятой и запись в dataGridView
                        dataTable.Rows.Add(x, Configurate.ToFixed(y, (uint)DecimalPlaces.ForY));
                        dataTable.Rows.Add(x, -Configurate.ToFixed(y, (uint)DecimalPlaces.ForY));
                    }
                }

                CassiniChart.Hide();

                if (AllTests.ValuesFit(arrOfY, lb, rb))
                {
                    CassiniChart.Show();
                }

                ConfigurateChart(lb, rb, arrOfY);
            }
        }

        private void coefC_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != (int)Symbols.Backspace && ch != ',' && ch != '-')
            {
                e.Handled = true;
            }
        }

        private void build_button_MouseEnter(object sender, EventArgs e)
        {
            build_button.BackgroundImage = Properties.Resources.gear1;
        }

        private void build_button_MouseLeave(object sender, EventArgs e)
        {
            build_button.BackgroundImage = Properties.Resources.gear2;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа строит график функции овала Кассини.", "Info");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CassiniChart.Visible)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Image|*.png",
                    Title = "Сохранить как png",
                    FileName = "Sample.png"
                };

                DialogResult result = saveFileDialog.ShowDialog();
                saveFileDialog.RestoreDirectory = true;

                CassiniChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            } else
            {
                MessageBox.Show("Сперва необходимо построить график!");
            }
        }

        private void SaveExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CassiniChart.Visible)
            {
                ExcelExport.Export(dataTable);
            } else
            {
                MessageBox.Show("Сперва необходимо построить график!");
            }
        }
    }
}

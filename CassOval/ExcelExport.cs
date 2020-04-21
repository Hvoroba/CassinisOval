// ExcelExport.cs
// Лабораторная работа №3.
// Студент группы 485, Дмитриев Никита Дмитриевич. 2020 год

using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System;

namespace CassOval
{
    class ExcelExport
    {
        internal static void Export(DataGridView dataTable)
        {
            _Application excelApp = new _Excel.Application();

            Workbook wb;
            wb = excelApp.Workbooks.Add();

            Worksheet ws = wb.Worksheets[1];

            double[] arrOfX = new double[dataTable.Rows.Count - 1];
            double[] arrOfY = new double[dataTable.Rows.Count - 1];

            GetValues.FillArrays(arrOfX, arrOfY, dataTable);

            excelApp.Visible = true;

            excelApp.Cells[1, 1] = "X:";
            excelApp.Cells[1, 2] = "Y:";


            int row = 3;
            int column = 1; //начинать заполнение необходимо с 3 строчки, т к при построении графика левая верхняя клеточка должна быть пустой

            for (int i = 0; i < arrOfX.Length; i++)
            {
                excelApp.Cells[row, column] = arrOfX[i];
                column++;
                excelApp.Cells[row, column] = arrOfY[i];
                column--;
                row++;
            }

            _Excel.Range eRange = ws.get_Range("a2", "b" + row);

            _Excel.ChartObjects eChartObjects = (_Excel.ChartObjects)ws.ChartObjects(Type.Missing);
            _Excel.ChartObject eChartObj = eChartObjects.Add(10, 30, 300, 300); //размеры диаграммы
            _Excel.Chart eChart = eChartObj.Chart;

            eChart.ChartType = _Excel.XlChartType.xlLine;
            eChart.ChartWizard(
                Source: eRange,
                Title: "Cassini Oval",
                CategoryTitle: "xAxis",
                CategoryLabels: 2,
                ValueTitle: "yAxis",
                HasLegend: false);

            eChart.SetSourceData(eRange);
        }
    }
}

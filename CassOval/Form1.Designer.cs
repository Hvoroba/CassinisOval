namespace CassOval
{
    partial class CassiniOval
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.equation_PB = new System.Windows.Forms.PictureBox();
            this.build_button = new System.Windows.Forms.Button();
            this.coefC_tb = new System.Windows.Forms.TextBox();
            this.coefA_tb = new System.Windows.Forms.TextBox();
            this.step_tb = new System.Windows.Forms.TextBox();
            this.rightBorder_tb = new System.Windows.Forms.TextBox();
            this.leftBorder_tb = new System.Windows.Forms.TextBox();
            this.coefC_lbl = new System.Windows.Forms.Label();
            this.coefA_lbl = new System.Windows.Forms.Label();
            this.step_lbl = new System.Windows.Forms.Label();
            this.rightBorder_lbl = new System.Windows.Forms.Label();
            this.leftBorder_lbl = new System.Windows.Forms.Label();
            this.CassiniChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.xColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equation_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CassiniChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // equation_PB
            // 
            this.equation_PB.BackColor = System.Drawing.Color.Transparent;
            this.equation_PB.Image = global::CassOval.Properties.Resources.Cassini;
            this.equation_PB.Location = new System.Drawing.Point(122, 456);
            this.equation_PB.Name = "equation_PB";
            this.equation_PB.Size = new System.Drawing.Size(266, 50);
            this.equation_PB.TabIndex = 24;
            this.equation_PB.TabStop = false;
            // 
            // build_button
            // 
            this.build_button.BackgroundImage = global::CassOval.Properties.Resources.gear2;
            this.build_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.build_button.Location = new System.Drawing.Point(349, 44);
            this.build_button.Name = "build_button";
            this.build_button.Size = new System.Drawing.Size(128, 39);
            this.build_button.TabIndex = 23;
            this.build_button.Text = "Построить";
            this.build_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.build_button.UseVisualStyleBackColor = true;
            this.build_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.build_button_MouseClick);
            this.build_button.MouseEnter += new System.EventHandler(this.build_button_MouseEnter);
            this.build_button.MouseLeave += new System.EventHandler(this.build_button_MouseLeave);
            // 
            // coefC_tb
            // 
            this.coefC_tb.Location = new System.Drawing.Point(7, 314);
            this.coefC_tb.MaxLength = 10;
            this.coefC_tb.Name = "coefC_tb";
            this.coefC_tb.ShortcutsEnabled = false;
            this.coefC_tb.Size = new System.Drawing.Size(81, 20);
            this.coefC_tb.TabIndex = 22;
            this.coefC_tb.Text = "10";
            this.coefC_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coefC_tb_KeyPress);
            // 
            // coefA_tb
            // 
            this.coefA_tb.Location = new System.Drawing.Point(7, 254);
            this.coefA_tb.MaxLength = 10;
            this.coefA_tb.Name = "coefA_tb";
            this.coefA_tb.ShortcutsEnabled = false;
            this.coefA_tb.Size = new System.Drawing.Size(81, 20);
            this.coefA_tb.TabIndex = 21;
            this.coefA_tb.Text = "100";
            this.coefA_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coefC_tb_KeyPress);
            // 
            // step_tb
            // 
            this.step_tb.Location = new System.Drawing.Point(7, 194);
            this.step_tb.MaxLength = 10;
            this.step_tb.Name = "step_tb";
            this.step_tb.ShortcutsEnabled = false;
            this.step_tb.Size = new System.Drawing.Size(81, 20);
            this.step_tb.TabIndex = 20;
            this.step_tb.Text = "1";
            this.step_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coefC_tb_KeyPress);
            // 
            // rightBorder_tb
            // 
            this.rightBorder_tb.Location = new System.Drawing.Point(7, 134);
            this.rightBorder_tb.MaxLength = 10;
            this.rightBorder_tb.Name = "rightBorder_tb";
            this.rightBorder_tb.ShortcutsEnabled = false;
            this.rightBorder_tb.Size = new System.Drawing.Size(81, 20);
            this.rightBorder_tb.TabIndex = 19;
            this.rightBorder_tb.Text = "100";
            this.rightBorder_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coefC_tb_KeyPress);
            // 
            // leftBorder_tb
            // 
            this.leftBorder_tb.Location = new System.Drawing.Point(7, 74);
            this.leftBorder_tb.MaxLength = 10;
            this.leftBorder_tb.Name = "leftBorder_tb";
            this.leftBorder_tb.ShortcutsEnabled = false;
            this.leftBorder_tb.Size = new System.Drawing.Size(81, 20);
            this.leftBorder_tb.TabIndex = 18;
            this.leftBorder_tb.Text = "-100";
            this.leftBorder_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.coefC_tb_KeyPress);
            // 
            // coefC_lbl
            // 
            this.coefC_lbl.AutoSize = true;
            this.coefC_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.coefC_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefC_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coefC_lbl.Location = new System.Drawing.Point(7, 284);
            this.coefC_lbl.Name = "coefC_lbl";
            this.coefC_lbl.Size = new System.Drawing.Size(137, 20);
            this.coefC_lbl.TabIndex = 17;
            this.coefC_lbl.Text = "Коэффициент c:";
            // 
            // coefA_lbl
            // 
            this.coefA_lbl.AutoSize = true;
            this.coefA_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.coefA_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefA_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.coefA_lbl.Location = new System.Drawing.Point(7, 224);
            this.coefA_lbl.Name = "coefA_lbl";
            this.coefA_lbl.Size = new System.Drawing.Size(138, 20);
            this.coefA_lbl.TabIndex = 16;
            this.coefA_lbl.Text = "Коэффициент a:";
            // 
            // step_lbl
            // 
            this.step_lbl.AutoSize = true;
            this.step_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.step_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.step_lbl.Location = new System.Drawing.Point(7, 164);
            this.step_lbl.Name = "step_lbl";
            this.step_lbl.Size = new System.Drawing.Size(42, 20);
            this.step_lbl.TabIndex = 15;
            this.step_lbl.Text = "Шаг:";
            // 
            // rightBorder_lbl
            // 
            this.rightBorder_lbl.AutoSize = true;
            this.rightBorder_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rightBorder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightBorder_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightBorder_lbl.Location = new System.Drawing.Point(7, 104);
            this.rightBorder_lbl.Name = "rightBorder_lbl";
            this.rightBorder_lbl.Size = new System.Drawing.Size(139, 20);
            this.rightBorder_lbl.TabIndex = 14;
            this.rightBorder_lbl.Text = "Правая граница: ";
            // 
            // leftBorder_lbl
            // 
            this.leftBorder_lbl.AutoSize = true;
            this.leftBorder_lbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.leftBorder_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftBorder_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftBorder_lbl.Location = new System.Drawing.Point(7, 44);
            this.leftBorder_lbl.Name = "leftBorder_lbl";
            this.leftBorder_lbl.Size = new System.Drawing.Size(130, 20);
            this.leftBorder_lbl.TabIndex = 13;
            this.leftBorder_lbl.Text = "Левая граница: ";
            // 
            // CassiniChart
            // 
            this.CassiniChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartArea2.Name = "ChartArea1";
            this.CassiniChart.ChartAreas.Add(chartArea2);
            this.CassiniChart.Location = new System.Drawing.Point(0, 503);
            this.CassiniChart.Name = "CassiniChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Name = "Series2";
            this.CassiniChart.Series.Add(series3);
            this.CassiniChart.Series.Add(series4);
            this.CassiniChart.Size = new System.Drawing.Size(490, 213);
            this.CassiniChart.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 27);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePngToolStripMenuItem,
            this.SaveExcelToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SavePngToolStripMenuItem
            // 
            this.SavePngToolStripMenuItem.Name = "SavePngToolStripMenuItem";
            this.SavePngToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.SavePngToolStripMenuItem.Text = "Сохранить";
            this.SavePngToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // SaveExcelToolStripMenuItem
            // 
            this.SaveExcelToolStripMenuItem.Name = "SaveExcelToolStripMenuItem";
            this.SaveExcelToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.SaveExcelToolStripMenuItem.Text = "Сохрать в Excel";
            this.SaveExcelToolStripMenuItem.Click += new System.EventHandler(this.SaveExcelToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 23);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataTable
            // 
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xColumn,
            this.yColumn});
            this.dataTable.Location = new System.Drawing.Point(90, 722);
            this.dataTable.Name = "dataTable";
            this.dataTable.Size = new System.Drawing.Size(298, 107);
            this.dataTable.TabIndex = 27;
            // 
            // xColumn
            // 
            this.xColumn.Frozen = true;
            this.xColumn.HeaderText = "X:";
            this.xColumn.Name = "xColumn";
            this.xColumn.ReadOnly = true;
            this.xColumn.Width = 42;
            // 
            // yColumn
            // 
            this.yColumn.Frozen = true;
            this.yColumn.HeaderText = "Y:";
            this.yColumn.Name = "yColumn";
            this.yColumn.ReadOnly = true;
            this.yColumn.Width = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::CassOval.Properties.Resources.first;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 686);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.CassiniChart);
            this.Controls.Add(this.equation_PB);
            this.Controls.Add(this.build_button);
            this.Controls.Add(this.coefC_tb);
            this.Controls.Add(this.coefA_tb);
            this.Controls.Add(this.step_tb);
            this.Controls.Add(this.rightBorder_tb);
            this.Controls.Add(this.leftBorder_tb);
            this.Controls.Add(this.coefC_lbl);
            this.Controls.Add(this.coefA_lbl);
            this.Controls.Add(this.step_lbl);
            this.Controls.Add(this.rightBorder_lbl);
            this.Controls.Add(this.leftBorder_lbl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.equation_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CassiniChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox equation_PB;
        private System.Windows.Forms.Button build_button;
        private System.Windows.Forms.TextBox coefC_tb;
        private System.Windows.Forms.TextBox coefA_tb;
        private System.Windows.Forms.TextBox step_tb;
        private System.Windows.Forms.TextBox rightBorder_tb;
        private System.Windows.Forms.TextBox leftBorder_tb;
        private System.Windows.Forms.Label coefC_lbl;
        private System.Windows.Forms.Label coefA_lbl;
        private System.Windows.Forms.Label step_lbl;
        private System.Windows.Forms.Label rightBorder_lbl;
        private System.Windows.Forms.Label leftBorder_lbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart CassiniChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn xColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveExcelToolStripMenuItem;
    }
}


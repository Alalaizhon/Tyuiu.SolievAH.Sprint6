
namespace Tyuiu.SolievAH.Sprint6.Task5.V23
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTopSide_SAH = new System.Windows.Forms.Panel();
            this.panelLeftSide_SAH = new System.Windows.Forms.Panel();
            this.panelFill_SAH = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.buttonOpenF_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.groupBoxOutPut_SAH = new System.Windows.Forms.GroupBox();
            this.chartFunction_SAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_SAH = new System.Windows.Forms.DataGridView();
            this.panelTopSide_SAH.SuspendLayout();
            this.panelLeftSide_SAH.SuspendLayout();
            this.panelFill_SAH.SuspendLayout();
            this.groupBoxTask_SAH.SuspendLayout();
            this.groupBoxOutPut_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSide_SAH
            // 
            this.panelTopSide_SAH.Controls.Add(this.buttonDone_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonOpenF_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonHelp_SAH);
            this.panelTopSide_SAH.Controls.Add(this.groupBoxTask_SAH);
            this.panelTopSide_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide_SAH.Name = "panelTopSide_SAH";
            this.panelTopSide_SAH.Size = new System.Drawing.Size(844, 100);
            this.panelTopSide_SAH.TabIndex = 0;
            // 
            // panelLeftSide_SAH
            // 
            this.panelLeftSide_SAH.Controls.Add(this.groupBoxOutPut_SAH);
            this.panelLeftSide_SAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide_SAH.Location = new System.Drawing.Point(0, 100);
            this.panelLeftSide_SAH.Name = "panelLeftSide_SAH";
            this.panelLeftSide_SAH.Size = new System.Drawing.Size(135, 444);
            this.panelLeftSide_SAH.TabIndex = 1;
            // 
            // panelFill_SAH
            // 
            this.panelFill_SAH.Controls.Add(this.chartFunction_SAH);
            this.panelFill_SAH.Controls.Add(this.splitter1);
            this.panelFill_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAH.Location = new System.Drawing.Point(135, 100);
            this.panelFill_SAH.Name = "panelFill_SAH";
            this.panelFill_SAH.Size = new System.Drawing.Size(709, 444);
            this.panelFill_SAH.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 444);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBox1);
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(550, 75);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(538, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V23.txt. Вывести в dataGridView. \r\nВывест" +
    "и все числа, меньше 0. Построить диаграмму по этим значениям.";
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SAH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAH.Location = new System.Drawing.Point(748, 25);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(84, 56);
            this.buttonHelp_SAH.TabIndex = 1;
            this.buttonHelp_SAH.Text = "Справка";
            this.buttonHelp_SAH.UseVisualStyleBackColor = false;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // buttonOpenF_SAH
            // 
            this.buttonOpenF_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenF_SAH.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenF_SAH.Location = new System.Drawing.Point(657, 25);
            this.buttonOpenF_SAH.Name = "buttonOpenF_SAH";
            this.buttonOpenF_SAH.Size = new System.Drawing.Size(85, 56);
            this.buttonOpenF_SAH.TabIndex = 2;
            this.buttonOpenF_SAH.Text = "Открыть Файл";
            this.buttonOpenF_SAH.UseVisualStyleBackColor = false;
            this.buttonOpenF_SAH.Click += new System.EventHandler(this.buttonOpenF_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_SAH.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAH.Location = new System.Drawing.Point(566, 25);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(85, 56);
            this.buttonDone_SAH.TabIndex = 3;
            this.buttonDone_SAH.Text = "Выполнить";
            this.buttonDone_SAH.UseVisualStyleBackColor = false;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // groupBoxOutPut_SAH
            // 
            this.groupBoxOutPut_SAH.Controls.Add(this.dataGridViewResult_SAH);
            this.groupBoxOutPut_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SAH.Name = "groupBoxOutPut_SAH";
            this.groupBoxOutPut_SAH.Size = new System.Drawing.Size(135, 444);
            this.groupBoxOutPut_SAH.TabIndex = 0;
            this.groupBoxOutPut_SAH.TabStop = false;
            this.groupBoxOutPut_SAH.Text = "Вывод Данных:";
            // 
            // chartFunction_SAH
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SAH.ChartAreas.Add(chartArea2);
            this.chartFunction_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_SAH.Legends.Add(legend2);
            this.chartFunction_SAH.Location = new System.Drawing.Point(10, 0);
            this.chartFunction_SAH.Name = "chartFunction_SAH";
            this.chartFunction_SAH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SAH.Series.Add(series2);
            this.chartFunction_SAH.Size = new System.Drawing.Size(699, 444);
            this.chartFunction_SAH.TabIndex = 1;
            this.chartFunction_SAH.Text = "chartFunc_SAH";
            // 
            // dataGridViewResult_SAH
            // 
            this.dataGridViewResult_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_SAH.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_SAH.Name = "dataGridViewResult_SAH";
            this.dataGridViewResult_SAH.Size = new System.Drawing.Size(129, 425);
            this.dataGridViewResult_SAH.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 544);
            this.Controls.Add(this.panelFill_SAH);
            this.Controls.Add(this.panelLeftSide_SAH);
            this.Controls.Add(this.panelTopSide_SAH);
            this.MinimumSize = new System.Drawing.Size(860, 583);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 23 | Солиев А.Х.";
            this.panelTopSide_SAH.ResumeLayout(false);
            this.panelLeftSide_SAH.ResumeLayout(false);
            this.panelFill_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            this.groupBoxOutPut_SAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
        private System.Windows.Forms.Button buttonOpenF_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLeftSide_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAH;
        private System.Windows.Forms.Panel panelFill_SAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAH;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAH;
    }
}


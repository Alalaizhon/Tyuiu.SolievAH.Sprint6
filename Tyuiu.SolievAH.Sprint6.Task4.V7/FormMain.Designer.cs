
using System;

namespace Tyuiu.SolievAH.Sprint6.Task4.V7
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTopSide_SAH = new System.Windows.Forms.Panel();
            this.groupBoxStep_SAH = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SAH = new System.Windows.Forms.Label();
            this.labelStartStep_SAH = new System.Windows.Forms.Label();
            this.textBoxStopStep_SAH = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.panelLeftSide_SAH = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_SAH = new System.Windows.Forms.GroupBox();
            this.panelFill_SAH = new System.Windows.Forms.Panel();
            this.chartFunction_SAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.buttonSave_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.textBoxResult_SAH = new System.Windows.Forms.TextBox();
            this.panelTopSide_SAH.SuspendLayout();
            this.groupBoxStep_SAH.SuspendLayout();
            this.groupBoxTask_SAH.SuspendLayout();
            this.panelLeftSide_SAH.SuspendLayout();
            this.groupBoxOutPut_SAH.SuspendLayout();
            this.panelFill_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSide_SAH
            // 
            this.panelTopSide_SAH.Controls.Add(this.buttonDone_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonSave_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonHelp_SAH);
            this.panelTopSide_SAH.Controls.Add(this.groupBoxStep_SAH);
            this.panelTopSide_SAH.Controls.Add(this.groupBoxTask_SAH);
            this.panelTopSide_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide_SAH.Name = "panelTopSide_SAH";
            this.panelTopSide_SAH.Size = new System.Drawing.Size(1037, 100);
            this.panelTopSide_SAH.TabIndex = 0;
            // 
            // groupBoxStep_SAH
            // 
            this.groupBoxStep_SAH.Controls.Add(this.labelStopStep_SAH);
            this.groupBoxStep_SAH.Controls.Add(this.labelStartStep_SAH);
            this.groupBoxStep_SAH.Controls.Add(this.textBoxStopStep_SAH);
            this.groupBoxStep_SAH.Controls.Add(this.textBoxStartStep_SAH);
            this.groupBoxStep_SAH.Location = new System.Drawing.Point(433, 12);
            this.groupBoxStep_SAH.Name = "groupBoxStep_SAH";
            this.groupBoxStep_SAH.Size = new System.Drawing.Size(232, 82);
            this.groupBoxStep_SAH.TabIndex = 4;
            this.groupBoxStep_SAH.TabStop = false;
            this.groupBoxStep_SAH.Text = "b";
            // 
            // labelStopStep_SAH
            // 
            this.labelStopStep_SAH.AutoSize = true;
            this.labelStopStep_SAH.Location = new System.Drawing.Point(109, 35);
            this.labelStopStep_SAH.Name = "labelStopStep_SAH";
            this.labelStopStep_SAH.Size = new System.Drawing.Size(73, 13);
            this.labelStopStep_SAH.TabIndex = 1;
            this.labelStopStep_SAH.Text = "Конец Шага: ";
            // 
            // labelStartStep_SAH
            // 
            this.labelStartStep_SAH.AutoSize = true;
            this.labelStartStep_SAH.Location = new System.Drawing.Point(6, 35);
            this.labelStartStep_SAH.Name = "labelStartStep_SAH";
            this.labelStartStep_SAH.Size = new System.Drawing.Size(71, 13);
            this.labelStartStep_SAH.TabIndex = 1;
            this.labelStartStep_SAH.Text = "Старт Шага: ";
            // 
            // textBoxStopStep_SAH
            // 
            this.textBoxStopStep_SAH.Location = new System.Drawing.Point(112, 51);
            this.textBoxStopStep_SAH.Name = "textBoxStopStep_SAH";
            this.textBoxStopStep_SAH.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_SAH.TabIndex = 0;
            this.textBoxStopStep_SAH.Text = "5";
            // 
            // textBoxStartStep_SAH
            // 
            this.textBoxStartStep_SAH.Location = new System.Drawing.Point(6, 51);
            this.textBoxStartStep_SAH.Name = "textBoxStartStep_SAH";
            this.textBoxStartStep_SAH.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_SAH.TabIndex = 0;
            this.textBoxStartStep_SAH.Text = "-5";
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(424, 97);
            this.groupBoxTask_SAH.TabIndex = 3;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие: ";
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(408, 72);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = "Протабулировать функцию cos (x) на заданном диапазоне от -5 до 5\r\nРезультат вывес" +
    "ти в textBox, построить график функций и сохранить в файл\r\nOutPutFileTask.txt по" +
    " нажатию кнопки\r\n ";
            // 
            // panelLeftSide_SAH
            // 
            this.panelLeftSide_SAH.Controls.Add(this.groupBoxOutPut_SAH);
            this.panelLeftSide_SAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide_SAH.Location = new System.Drawing.Point(0, 100);
            this.panelLeftSide_SAH.Name = "panelLeftSide_SAH";
            this.panelLeftSide_SAH.Size = new System.Drawing.Size(200, 437);
            this.panelLeftSide_SAH.TabIndex = 0;
            // 
            // groupBoxOutPut_SAH
            // 
            this.groupBoxOutPut_SAH.Controls.Add(this.textBoxResult_SAH);
            this.groupBoxOutPut_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_SAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_SAH.Name = "groupBoxOutPut_SAH";
            this.groupBoxOutPut_SAH.Size = new System.Drawing.Size(200, 437);
            this.groupBoxOutPut_SAH.TabIndex = 0;
            this.groupBoxOutPut_SAH.TabStop = false;
            this.groupBoxOutPut_SAH.Text = "Вывод Данночки: ";
            // 
            // panelFill_SAH
            // 
            this.panelFill_SAH.Controls.Add(this.chartFunction_SAH);
            this.panelFill_SAH.Controls.Add(this.splitter1);
            this.panelFill_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAH.Location = new System.Drawing.Point(200, 100);
            this.panelFill_SAH.Name = "panelFill_SAH";
            this.panelFill_SAH.Size = new System.Drawing.Size(837, 437);
            this.panelFill_SAH.TabIndex = 0;
            // 
            // chartFunction_SAH
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SAH.ChartAreas.Add(chartArea2);
            this.chartFunction_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartFunction_SAH.Legends.Add(legend2);
            this.chartFunction_SAH.Location = new System.Drawing.Point(3, 0);
            this.chartFunction_SAH.Name = "chartFunction_SAH";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SAH.Series.Add(series2);
            this.chartFunction_SAH.Size = new System.Drawing.Size(834, 437);
            this.chartFunction_SAH.TabIndex = 1;
            this.chartFunction_SAH.Tag = "";
            title2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Navy;
            title2.Name = "TitleCos";
            title2.Text = "График фукнции cos(x)";
            this.chartFunction_SAH.Titles.Add(title2);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 437);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAH.Location = new System.Drawing.Point(941, 22);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp_SAH.TabIndex = 5;
            this.buttonHelp_SAH.Text = "Справка";
            this.buttonHelp_SAH.UseVisualStyleBackColor = false;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // buttonSave_SAH
            // 
            this.buttonSave_SAH.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_SAH.Location = new System.Drawing.Point(860, 22);
            this.buttonSave_SAH.Name = "buttonSave_SAH";
            this.buttonSave_SAH.Size = new System.Drawing.Size(75, 61);
            this.buttonSave_SAH.TabIndex = 6;
            this.buttonSave_SAH.Text = "Сохранить";
            this.buttonSave_SAH.UseVisualStyleBackColor = false;
            this.buttonSave_SAH.Click += new System.EventHandler(this.buttonSave_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAH.Location = new System.Drawing.Point(779, 22);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_SAH.TabIndex = 7;
            this.buttonDone_SAH.Text = "Выполнить";
            this.buttonDone_SAH.UseVisualStyleBackColor = false;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // textBoxResult_SAH
            // 
            this.textBoxResult_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_SAH.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_SAH.Multiline = true;
            this.textBoxResult_SAH.Name = "textBoxResult_SAH";
            this.textBoxResult_SAH.Size = new System.Drawing.Size(194, 418);
            this.textBoxResult_SAH.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 537);
            this.Controls.Add(this.panelFill_SAH);
            this.Controls.Add(this.panelLeftSide_SAH);
            this.Controls.Add(this.panelTopSide_SAH);
            this.MinimumSize = new System.Drawing.Size(950, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTopSide_SAH.ResumeLayout(false);
            this.groupBoxStep_SAH.ResumeLayout(false);
            this.groupBoxStep_SAH.PerformLayout();
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            this.panelLeftSide_SAH.ResumeLayout(false);
            this.groupBoxOutPut_SAH.ResumeLayout(false);
            this.groupBoxOutPut_SAH.PerformLayout();
            this.panelFill_SAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).EndInit();
            this.ResumeLayout(false);

        }

      
        #endregion

        private System.Windows.Forms.Panel panelTopSide_SAH;
        private System.Windows.Forms.Panel panelLeftSide_SAH;
        private System.Windows.Forms.Panel panelFill_SAH;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.GroupBox groupBoxStep_SAH;
        private System.Windows.Forms.Label labelStopStep_SAH;
        private System.Windows.Forms.Label labelStartStep_SAH;
        private System.Windows.Forms.TextBox textBoxStopStep_SAH;
        private System.Windows.Forms.TextBox textBoxStartStep_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.Button buttonSave_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
        private System.Windows.Forms.TextBox textBoxResult_SAH;
    }
}


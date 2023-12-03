
namespace Tyuiu.SolievAH.Sprint6.Task2.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAH = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SAH = new System.Windows.Forms.Label();
            this.textBoxStopStep_SAH = new System.Windows.Forms.TextBox();
            this.labelStartStep_SAH = new System.Windows.Forms.Label();
            this.textBoxStartStep_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SAH = new System.Windows.Forms.GroupBox();
            this.chartFunction_SAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_SAH = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOutPut_SAH = new System.Windows.Forms.Label();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.groupBoxTask_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput_SAH.SuspendLayout();
            this.groupBoxOutput_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.pictureBox1);
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(543, 257);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(358, 41);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = "Протабулировать функцию на заданном диапазоне\r\nРезультат вывести в DataGridView и" +
    " построить график функции";
            // 
            // groupBoxInput_SAH
            // 
            this.groupBoxInput_SAH.Controls.Add(this.labelStopStep_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.textBoxStopStep_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.labelStartStep_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.textBoxStartStep_SAH);
            this.groupBoxInput_SAH.Location = new System.Drawing.Point(12, 275);
            this.groupBoxInput_SAH.Name = "groupBoxInput_SAH";
            this.groupBoxInput_SAH.Size = new System.Drawing.Size(316, 65);
            this.groupBoxInput_SAH.TabIndex = 1;
            this.groupBoxInput_SAH.TabStop = false;
            this.groupBoxInput_SAH.Text = "Ввод Данных";
            // 
            // labelStopStep_SAH
            // 
            this.labelStopStep_SAH.AutoSize = true;
            this.labelStopStep_SAH.Location = new System.Drawing.Point(154, 24);
            this.labelStopStep_SAH.Name = "labelStopStep_SAH";
            this.labelStopStep_SAH.Size = new System.Drawing.Size(72, 13);
            this.labelStopStep_SAH.TabIndex = 1;
            this.labelStopStep_SAH.Text = "Конец шага: ";
            // 
            // textBoxStopStep_SAH
            // 
            this.textBoxStopStep_SAH.Location = new System.Drawing.Point(154, 40);
            this.textBoxStopStep_SAH.Name = "textBoxStopStep_SAH";
            this.textBoxStopStep_SAH.Size = new System.Drawing.Size(122, 20);
            this.textBoxStopStep_SAH.TabIndex = 0;
            this.textBoxStopStep_SAH.Text = "5";
            // 
            // labelStartStep_SAH
            // 
            this.labelStartStep_SAH.AutoSize = true;
            this.labelStartStep_SAH.Location = new System.Drawing.Point(6, 24);
            this.labelStartStep_SAH.Name = "labelStartStep_SAH";
            this.labelStartStep_SAH.Size = new System.Drawing.Size(70, 13);
            this.labelStartStep_SAH.TabIndex = 1;
            this.labelStartStep_SAH.Text = "Старт шага: ";
            // 
            // textBoxStartStep_SAH
            // 
            this.textBoxStartStep_SAH.Location = new System.Drawing.Point(6, 40);
            this.textBoxStartStep_SAH.Name = "textBoxStartStep_SAH";
            this.textBoxStartStep_SAH.Size = new System.Drawing.Size(121, 20);
            this.textBoxStartStep_SAH.TabIndex = 0;
            this.textBoxStartStep_SAH.Text = "-5";
            // 
            // groupBoxOutput_SAH
            // 
            this.groupBoxOutput_SAH.Controls.Add(this.chartFunction_SAH);
            this.groupBoxOutput_SAH.Controls.Add(this.dataGridViewFunction_SAH);
            this.groupBoxOutput_SAH.Controls.Add(this.labelOutPut_SAH);
            this.groupBoxOutput_SAH.Location = new System.Drawing.Point(561, 12);
            this.groupBoxOutput_SAH.Name = "groupBoxOutput_SAH";
            this.groupBoxOutput_SAH.Size = new System.Drawing.Size(486, 333);
            this.groupBoxOutput_SAH.TabIndex = 2;
            this.groupBoxOutput_SAH.TabStop = false;
            this.groupBoxOutput_SAH.Text = "Вывод Данных";
            // 
            // chartFunction_SAH
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_SAH.ChartAreas.Add(chartArea3);
            this.chartFunction_SAH.Location = new System.Drawing.Point(133, 36);
            this.chartFunction_SAH.Name = "chartFunction_SAH";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.chartFunction_SAH.Series.Add(series3);
            this.chartFunction_SAH.Size = new System.Drawing.Size(283, 278);
            this.chartFunction_SAH.TabIndex = 2;
            this.chartFunction_SAH.Text = "chart1";
            // 
            // dataGridViewFunction_SAH
            // 
            this.dataGridViewFunction_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SAH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Fx});
            this.dataGridViewFunction_SAH.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFunction_SAH.Name = "dataGridViewFunction_SAH";
            this.dataGridViewFunction_SAH.RowHeadersVisible = false;
            this.dataGridViewFunction_SAH.Size = new System.Drawing.Size(121, 278);
            this.dataGridViewFunction_SAH.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Fx
            // 
            this.Fx.HeaderText = "F(x)";
            this.Fx.Name = "Fx";
            this.Fx.Width = 50;
            // 
            // labelOutPut_SAH
            // 
            this.labelOutPut_SAH.AutoSize = true;
            this.labelOutPut_SAH.Location = new System.Drawing.Point(7, 20);
            this.labelOutPut_SAH.Name = "labelOutPut_SAH";
            this.labelOutPut_SAH.Size = new System.Drawing.Size(65, 13);
            this.labelOutPut_SAH.TabIndex = 0;
            this.labelOutPut_SAH.Text = "Результат: ";
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAH.FlatAppearance.BorderSize = 0;
            this.buttonHelp_SAH.Location = new System.Drawing.Point(334, 280);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(78, 60);
            this.buttonHelp_SAH.TabIndex = 3;
            this.buttonHelp_SAH.Text = "Справка";
            this.buttonHelp_SAH.UseVisualStyleBackColor = false;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SAH.Location = new System.Drawing.Point(418, 280);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(137, 60);
            this.buttonDone_SAH.TabIndex = 3;
            this.buttonDone_SAH.Text = "Выполнить";
            this.buttonDone_SAH.UseVisualStyleBackColor = false;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            this.buttonDone_SAH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SAH_MouseDown);
            this.buttonDone_SAH.MouseEnter += new System.EventHandler(this.buttonDone_SAH_MouseEnter);
            this.buttonDone_SAH.MouseLeave += new System.EventHandler(this.buttonDone_SAH_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 357);
            this.Controls.Add(this.buttonDone_SAH);
            this.Controls.Add(this.buttonHelp_SAH);
            this.Controls.Add(this.groupBoxOutput_SAH);
            this.Controls.Add(this.groupBoxInput_SAH);
            this.Controls.Add(this.groupBoxTask_SAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Солиев А.Х.";
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput_SAH.ResumeLayout(false);
            this.groupBoxInput_SAH.PerformLayout();
            this.groupBoxOutput_SAH.ResumeLayout(false);
            this.groupBoxOutput_SAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.GroupBox groupBoxInput_SAH;
        private System.Windows.Forms.Label labelStopStep_SAH;
        private System.Windows.Forms.TextBox textBoxStopStep_SAH;
        private System.Windows.Forms.Label labelStartStep_SAH;
        private System.Windows.Forms.TextBox textBoxStartStep_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAH;
        private System.Windows.Forms.Label labelOutPut_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fx;
    }
}


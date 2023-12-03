
namespace Tyuiu.SolievAH.Sprint6.Task1.V20
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
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_SAH = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SAH = new System.Windows.Forms.TextBox();
            this.labelStopValue_SAH = new System.Windows.Forms.Label();
            this.labelStartValue_SAH = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SAH = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.ButtonDone_SAH = new System.Windows.Forms.Button();
            this.groupBoxTask_SAH.SuspendLayout();
            this.groupBoxInput_SAH.SuspendLayout();
            this.groupBoxOutPutData_SAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(623, 329);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие";
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Location = new System.Drawing.Point(6, 32);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(611, 281);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = "Протабулировать Функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде т" +
    "аблицы.";
            // 
            // groupBoxInput_SAH
            // 
            this.groupBoxInput_SAH.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInput_SAH.Controls.Add(this.textBoxStopStep_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.textBoxStartStep_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.labelStopValue_SAH);
            this.groupBoxInput_SAH.Controls.Add(this.labelStartValue_SAH);
            this.groupBoxInput_SAH.Location = new System.Drawing.Point(18, 347);
            this.groupBoxInput_SAH.Name = "groupBoxInput_SAH";
            this.groupBoxInput_SAH.Size = new System.Drawing.Size(387, 86);
            this.groupBoxInput_SAH.TabIndex = 1;
            this.groupBoxInput_SAH.TabStop = false;
            this.groupBoxInput_SAH.Text = "Ввод Данных:";
            // 
            // textBoxStopStep_SAH
            // 
            this.textBoxStopStep_SAH.Location = new System.Drawing.Point(114, 43);
            this.textBoxStopStep_SAH.Name = "textBoxStopStep_SAH";
            this.textBoxStopStep_SAH.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_SAH.TabIndex = 2;
            this.textBoxStopStep_SAH.Text = "5";
            // 
            // textBoxStartStep_SAH
            // 
            this.textBoxStartStep_SAH.Location = new System.Drawing.Point(10, 43);
            this.textBoxStartStep_SAH.Name = "textBoxStartStep_SAH";
            this.textBoxStartStep_SAH.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_SAH.TabIndex = 2;
            this.textBoxStartStep_SAH.Text = "-5";
            // 
            // labelStopValue_SAH
            // 
            this.labelStopValue_SAH.AutoSize = true;
            this.labelStopValue_SAH.Location = new System.Drawing.Point(111, 27);
            this.labelStopValue_SAH.Name = "labelStopValue_SAH";
            this.labelStopValue_SAH.Size = new System.Drawing.Size(72, 13);
            this.labelStopValue_SAH.TabIndex = 1;
            this.labelStopValue_SAH.Text = "Конец шага: ";
            // 
            // labelStartValue_SAH
            // 
            this.labelStartValue_SAH.AutoSize = true;
            this.labelStartValue_SAH.Location = new System.Drawing.Point(7, 27);
            this.labelStartValue_SAH.Name = "labelStartValue_SAH";
            this.labelStartValue_SAH.Size = new System.Drawing.Size(70, 13);
            this.labelStartValue_SAH.TabIndex = 1;
            this.labelStartValue_SAH.Text = "Старт шага: ";
            // 
            // groupBoxOutPutData_SAH
            // 
            this.groupBoxOutPutData_SAH.Controls.Add(this.textBoxResult_SAH);
            this.groupBoxOutPutData_SAH.Location = new System.Drawing.Point(641, 12);
            this.groupBoxOutPutData_SAH.Name = "groupBoxOutPutData_SAH";
            this.groupBoxOutPutData_SAH.Size = new System.Drawing.Size(318, 421);
            this.groupBoxOutPutData_SAH.TabIndex = 2;
            this.groupBoxOutPutData_SAH.TabStop = false;
            this.groupBoxOutPutData_SAH.Text = "Вывод Данных: ";
            // 
            // textBoxResult_SAH
            // 
            this.textBoxResult_SAH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SAH.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_SAH.Multiline = true;
            this.textBoxResult_SAH.Name = "textBoxResult_SAH";
            this.textBoxResult_SAH.ReadOnly = true;
            this.textBoxResult_SAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SAH.Size = new System.Drawing.Size(297, 390);
            this.textBoxResult_SAH.TabIndex = 0;
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAH.Location = new System.Drawing.Point(411, 360);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(88, 61);
            this.buttonHelp_SAH.TabIndex = 3;
            this.buttonHelp_SAH.Text = "Справка";
            this.buttonHelp_SAH.UseVisualStyleBackColor = false;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // ButtonDone_SAH
            // 
            this.ButtonDone_SAH.BackColor = System.Drawing.Color.Green;
            this.ButtonDone_SAH.Location = new System.Drawing.Point(505, 360);
            this.ButtonDone_SAH.Name = "ButtonDone_SAH";
            this.ButtonDone_SAH.Size = new System.Drawing.Size(124, 61);
            this.ButtonDone_SAH.TabIndex = 3;
            this.ButtonDone_SAH.Text = "Выполнить";
            this.ButtonDone_SAH.UseVisualStyleBackColor = false;
            this.ButtonDone_SAH.Click += new System.EventHandler(this.ButtonDone_SAH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 438);
            this.Controls.Add(this.ButtonDone_SAH);
            this.Controls.Add(this.buttonHelp_SAH);
            this.Controls.Add(this.groupBoxOutPutData_SAH);
            this.Controls.Add(this.groupBoxInput_SAH);
            this.Controls.Add(this.groupBoxTask_SAH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 20 | Солиев А.Х.";
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            this.groupBoxInput_SAH.ResumeLayout(false);
            this.groupBoxInput_SAH.PerformLayout();
            this.groupBoxOutPutData_SAH.ResumeLayout(false);
            this.groupBoxOutPutData_SAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.GroupBox groupBoxInput_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_SAH;
        private System.Windows.Forms.TextBox textBoxResult_SAH;
        private System.Windows.Forms.Label labelStopValue_SAH;
        private System.Windows.Forms.Label labelStartValue_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.TextBox textBoxStopStep_SAH;
        private System.Windows.Forms.TextBox textBoxStartStep_SAH;
        private System.Windows.Forms.Button ButtonDone_SAH;
    }
}


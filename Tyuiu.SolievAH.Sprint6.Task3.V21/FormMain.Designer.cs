
namespace Tyuiu.SolievAH.Sprint6.Task3.V21
{
    partial class FormMain_SAH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAH));
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SAH = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SAH = new System.Windows.Forms.GroupBox();
            this.labelResult_SAH = new System.Windows.Forms.Label();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.groupBoxTask_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAH)).BeginInit();
            this.groupBoxOutput_SAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(389, 176);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие";
            // 
            // dataGridViewMatrix_SAH
            // 
            this.dataGridViewMatrix_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SAH.Location = new System.Drawing.Point(9, 39);
            this.dataGridViewMatrix_SAH.Name = "dataGridViewMatrix_SAH";
            this.dataGridViewMatrix_SAH.RowHeadersVisible = false;
            this.dataGridViewMatrix_SAH.Size = new System.Drawing.Size(309, 297);
            this.dataGridViewMatrix_SAH.TabIndex = 1;
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(337, 141);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = resources.GetString("textBoxTask_SAH.Text");
            // 
            // groupBoxOutput_SAH
            // 
            this.groupBoxOutput_SAH.Controls.Add(this.dataGridViewMatrix_SAH);
            this.groupBoxOutput_SAH.Controls.Add(this.labelResult_SAH);
            this.groupBoxOutput_SAH.Location = new System.Drawing.Point(424, 12);
            this.groupBoxOutput_SAH.Name = "groupBoxOutput_SAH";
            this.groupBoxOutput_SAH.Size = new System.Drawing.Size(328, 346);
            this.groupBoxOutput_SAH.TabIndex = 1;
            this.groupBoxOutput_SAH.TabStop = false;
            this.groupBoxOutput_SAH.Text = "Вывод Данных: ";
            // 
            // labelResult_SAH
            // 
            this.labelResult_SAH.AutoSize = true;
            this.labelResult_SAH.Location = new System.Drawing.Point(6, 23);
            this.labelResult_SAH.Name = "labelResult_SAH";
            this.labelResult_SAH.Size = new System.Drawing.Size(65, 13);
            this.labelResult_SAH.TabIndex = 1;
            this.labelResult_SAH.Text = "Результат: ";
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.Location = new System.Drawing.Point(287, 320);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(27, 28);
            this.buttonHelp_SAH.TabIndex = 2;
            this.buttonHelp_SAH.Text = "?";
            this.buttonHelp_SAH.UseVisualStyleBackColor = true;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.Location = new System.Drawing.Point(320, 320);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(81, 28);
            this.buttonDone_SAH.TabIndex = 2;
            this.buttonDone_SAH.Text = "Выполнить";
            this.buttonDone_SAH.UseVisualStyleBackColor = true;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // FormMain_SAH
            // 
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(760, 361);
            this.Controls.Add(this.buttonDone_SAH);
            this.Controls.Add(this.buttonHelp_SAH);
            this.Controls.Add(this.groupBoxOutput_SAH);
            this.Controls.Add(this.groupBoxTask_SAH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SAH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 21 | Солиев А.Х.";
            this.Load += new System.EventHandler(this.FormMain_SAH_Load);
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SAH)).EndInit();
            this.groupBoxOutput_SAH.ResumeLayout(false);
            this.groupBoxOutput_SAH.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SAH;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAH;
        private System.Windows.Forms.Label labelResult_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
    }
}


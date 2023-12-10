
namespace Tyuiu.SolievAH.Sprint6.Task7.V29
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTopSide_SAH = new System.Windows.Forms.Panel();
            this.panelFill_SAH = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SAH = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_SAH = new System.Windows.Forms.GroupBox();
            this.buttonOpen_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.buttonSave_SAH = new System.Windows.Forms.Button();
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.dataGridViewIn_SAH = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPut_SAH = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_SAH = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_SAH = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_SAH = new System.Windows.Forms.SaveFileDialog();
            this.panelTopSide_SAH.SuspendLayout();
            this.panelFill_SAH.SuspendLayout();
            this.groupBoxTask_SAH.SuspendLayout();
            this.groupBoxInput_SAH.SuspendLayout();
            this.groupBoxOutPut_SAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopSide_SAH
            // 
            this.panelTopSide_SAH.Controls.Add(this.buttonHelp_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonSave_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonDone_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonOpen_SAH);
            this.panelTopSide_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide_SAH.Name = "panelTopSide_SAH";
            this.panelTopSide_SAH.Size = new System.Drawing.Size(1041, 63);
            this.panelTopSide_SAH.TabIndex = 0;
            // 
            // panelFill_SAH
            // 
            this.panelFill_SAH.Controls.Add(this.groupBoxOutPut_SAH);
            this.panelFill_SAH.Controls.Add(this.groupBoxInput_SAH);
            this.panelFill_SAH.Controls.Add(this.groupBoxTask_SAH);
            this.panelFill_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SAH.Location = new System.Drawing.Point(0, 63);
            this.panelFill_SAH.Name = "panelFill_SAH";
            this.panelFill_SAH.Size = new System.Drawing.Size(1041, 513);
            this.panelFill_SAH.TabIndex = 1;
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(1041, 72);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие";
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SAH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SAH.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(1035, 53);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = resources.GetString("textBoxTask_SAH.Text");
            // 
            // groupBoxInput_SAH
            // 
            this.groupBoxInput_SAH.Controls.Add(this.dataGridViewIn_SAH);
            this.groupBoxInput_SAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInput_SAH.Location = new System.Drawing.Point(0, 72);
            this.groupBoxInput_SAH.Name = "groupBoxInput_SAH";
            this.groupBoxInput_SAH.Size = new System.Drawing.Size(488, 441);
            this.groupBoxInput_SAH.TabIndex = 1;
            this.groupBoxInput_SAH.TabStop = false;
            this.groupBoxInput_SAH.Text = "Ввод";
            // 
            // groupBoxOutPut_SAH
            // 
            this.groupBoxOutPut_SAH.Controls.Add(this.dataGridViewOutPut_SAH);
            this.groupBoxOutPut_SAH.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxOutPut_SAH.Location = new System.Drawing.Point(494, 72);
            this.groupBoxOutPut_SAH.Name = "groupBoxOutPut_SAH";
            this.groupBoxOutPut_SAH.Size = new System.Drawing.Size(547, 441);
            this.groupBoxOutPut_SAH.TabIndex = 2;
            this.groupBoxOutPut_SAH.TabStop = false;
            this.groupBoxOutPut_SAH.Text = "Вывод";
            // 
            // buttonOpen_SAH
            // 
            this.buttonOpen_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SAH.Image")));
            this.buttonOpen_SAH.Location = new System.Drawing.Point(12, 3);
            this.buttonOpen_SAH.Name = "buttonOpen_SAH";
            this.buttonOpen_SAH.Size = new System.Drawing.Size(75, 57);
            this.buttonOpen_SAH.TabIndex = 0;
            this.toolTipInfo_SAH.SetToolTip(this.buttonOpen_SAH, "Выбор файла.\r\n");
            this.buttonOpen_SAH.UseVisualStyleBackColor = true;
            this.buttonOpen_SAH.Click += new System.EventHandler(this.buttonOpen_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAH.Image")));
            this.buttonDone_SAH.Location = new System.Drawing.Point(93, 3);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(75, 57);
            this.buttonDone_SAH.TabIndex = 0;
            this.toolTipInfo_SAH.SetToolTip(this.buttonDone_SAH, "Выполнить изменения\r\n");
            this.buttonDone_SAH.UseVisualStyleBackColor = true;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // buttonSave_SAH
            // 
            this.buttonSave_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_SAH.Image")));
            this.buttonSave_SAH.Location = new System.Drawing.Point(174, 3);
            this.buttonSave_SAH.Name = "buttonSave_SAH";
            this.buttonSave_SAH.Size = new System.Drawing.Size(71, 57);
            this.buttonSave_SAH.TabIndex = 0;
            this.toolTipInfo_SAH.SetToolTip(this.buttonSave_SAH, "Сохранения результата\r\n");
            this.buttonSave_SAH.UseVisualStyleBackColor = true;
            this.buttonSave_SAH.Click += new System.EventHandler(this.buttonSave_SAH_Click);
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAH.Image")));
            this.buttonHelp_SAH.Location = new System.Drawing.Point(967, 3);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(71, 57);
            this.buttonHelp_SAH.TabIndex = 0;
            this.toolTipInfo_SAH.SetToolTip(this.buttonHelp_SAH, "О программе\r\n");
            this.buttonHelp_SAH.UseVisualStyleBackColor = true;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // dataGridViewIn_SAH
            // 
            this.dataGridViewIn_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_SAH.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_SAH.Name = "dataGridViewIn_SAH";
            this.dataGridViewIn_SAH.Size = new System.Drawing.Size(482, 422);
            this.dataGridViewIn_SAH.TabIndex = 0;
            // 
            // dataGridViewOutPut_SAH
            // 
            this.dataGridViewOutPut_SAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_SAH.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_SAH.Name = "dataGridViewOutPut_SAH";
            this.dataGridViewOutPut_SAH.Size = new System.Drawing.Size(541, 422);
            this.dataGridViewOutPut_SAH.TabIndex = 0;
            // 
            // openFileDialogTask_SAH
            // 
            this.openFileDialogTask_SAH.FileName = "openFileDialogTask_SAH";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 576);
            this.Controls.Add(this.panelFill_SAH);
            this.Controls.Add(this.panelTopSide_SAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 29 | Солиев А.Х.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTopSide_SAH.ResumeLayout(false);
            this.panelFill_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            this.groupBoxInput_SAH.ResumeLayout(false);
            this.groupBoxOutPut_SAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_SAH;
        private System.Windows.Forms.Panel panelFill_SAH;
        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.Button buttonHelp_SAH;
        private System.Windows.Forms.Button buttonSave_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
        private System.Windows.Forms.Button buttonOpen_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SAH;
        private System.Windows.Forms.GroupBox groupBoxInput_SAH;
        private System.Windows.Forms.DataGridView dataGridViewIn_SAH;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAH;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAH;
        private System.Windows.Forms.ToolTip toolTipInfo_SAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_SAH;
    }
}


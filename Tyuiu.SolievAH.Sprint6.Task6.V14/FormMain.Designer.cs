
namespace Tyuiu.SolievAH.Sprint6.Task6.V14
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
            this.panelOsnova_SAH = new System.Windows.Forms.Panel();
            this.groupBoxTask_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SAH = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_SAH = new System.Windows.Forms.TextBox();
            this.buttonOpen_SAH = new System.Windows.Forms.Button();
            this.buttonDone_SAH = new System.Windows.Forms.Button();
            this.textBoxInPut_SAH = new System.Windows.Forms.TextBox();
            this.groupBoxIn_SAH = new System.Windows.Forms.GroupBox();
            this.openFileDialog_SAH = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonHelp_SAH = new System.Windows.Forms.Button();
            this.panelTopSide_SAH.SuspendLayout();
            this.panelOsnova_SAH.SuspendLayout();
            this.groupBoxTask_SAH.SuspendLayout();
            this.groupBoxOutput_SAH.SuspendLayout();
            this.groupBoxIn_SAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopSide_SAH
            // 
            this.panelTopSide_SAH.Controls.Add(this.buttonHelp_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonDone_SAH);
            this.panelTopSide_SAH.Controls.Add(this.buttonOpen_SAH);
            this.panelTopSide_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide_SAH.Location = new System.Drawing.Point(0, 0);
            this.panelTopSide_SAH.Name = "panelTopSide_SAH";
            this.panelTopSide_SAH.Size = new System.Drawing.Size(800, 56);
            this.panelTopSide_SAH.TabIndex = 0;
            // 
            // panelOsnova_SAH
            // 
            this.panelOsnova_SAH.Controls.Add(this.groupBoxOutput_SAH);
            this.panelOsnova_SAH.Controls.Add(this.groupBoxIn_SAH);
            this.panelOsnova_SAH.Controls.Add(this.groupBoxTask_SAH);
            this.panelOsnova_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOsnova_SAH.Location = new System.Drawing.Point(0, 56);
            this.panelOsnova_SAH.Name = "panelOsnova_SAH";
            this.panelOsnova_SAH.Size = new System.Drawing.Size(800, 394);
            this.panelOsnova_SAH.TabIndex = 2;
            // 
            // groupBoxTask_SAH
            // 
            this.groupBoxTask_SAH.Controls.Add(this.textBoxTask_SAH);
            this.groupBoxTask_SAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_SAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_SAH.Name = "groupBoxTask_SAH";
            this.groupBoxTask_SAH.Size = new System.Drawing.Size(800, 66);
            this.groupBoxTask_SAH.TabIndex = 0;
            this.groupBoxTask_SAH.TabStop = false;
            this.groupBoxTask_SAH.Text = "Условие: ";
            // 
            // textBoxTask_SAH
            // 
            this.textBoxTask_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_SAH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SAH.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_SAH.Multiline = true;
            this.textBoxTask_SAH.Name = "textBoxTask_SAH";
            this.textBoxTask_SAH.ReadOnly = true;
            this.textBoxTask_SAH.Size = new System.Drawing.Size(794, 47);
            this.textBoxTask_SAH.TabIndex = 0;
            this.textBoxTask_SAH.Text = resources.GetString("textBoxTask_SAH.Text");
            // 
            // groupBoxOutput_SAH
            // 
            this.groupBoxOutput_SAH.Controls.Add(this.textBoxOutPut_SAH);
            this.groupBoxOutput_SAH.Location = new System.Drawing.Point(410, 72);
            this.groupBoxOutput_SAH.Name = "groupBoxOutput_SAH";
            this.groupBoxOutput_SAH.Size = new System.Drawing.Size(378, 319);
            this.groupBoxOutput_SAH.TabIndex = 2;
            this.groupBoxOutput_SAH.TabStop = false;
            this.groupBoxOutput_SAH.Text = "Вывод: ";
            // 
            // textBoxOutPut_SAH
            // 
            this.textBoxOutPut_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_SAH.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_SAH.Multiline = true;
            this.textBoxOutPut_SAH.Name = "textBoxOutPut_SAH";
            this.textBoxOutPut_SAH.ReadOnly = true;
            this.textBoxOutPut_SAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_SAH.Size = new System.Drawing.Size(372, 300);
            this.textBoxOutPut_SAH.TabIndex = 0;
            // 
            // buttonOpen_SAH
            // 
            this.buttonOpen_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_SAH.Image")));
            this.buttonOpen_SAH.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen_SAH.Name = "buttonOpen_SAH";
            this.buttonOpen_SAH.Size = new System.Drawing.Size(69, 50);
            this.buttonOpen_SAH.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpen_SAH, "Открыть файл.\r\nВыберите нужный файл для обработки.\r\n");
            this.buttonOpen_SAH.UseVisualStyleBackColor = true;
            this.buttonOpen_SAH.Click += new System.EventHandler(this.buttonOpen_SAH_Click);
            // 
            // buttonDone_SAH
            // 
            this.buttonDone_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_SAH.Image")));
            this.buttonDone_SAH.Location = new System.Drawing.Point(78, 3);
            this.buttonDone_SAH.Name = "buttonDone_SAH";
            this.buttonDone_SAH.Size = new System.Drawing.Size(69, 50);
            this.buttonDone_SAH.TabIndex = 0;
            this.buttonDone_SAH.UseVisualStyleBackColor = true;
            this.buttonDone_SAH.Click += new System.EventHandler(this.buttonDone_SAH_Click);
            // 
            // textBoxInPut_SAH
            // 
            this.textBoxInPut_SAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_SAH.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPut_SAH.Multiline = true;
            this.textBoxInPut_SAH.Name = "textBoxInPut_SAH";
            this.textBoxInPut_SAH.ReadOnly = true;
            this.textBoxInPut_SAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_SAH.Size = new System.Drawing.Size(375, 300);
            this.textBoxInPut_SAH.TabIndex = 0;
            // 
            // groupBoxIn_SAH
            // 
            this.groupBoxIn_SAH.Controls.Add(this.textBoxInPut_SAH);
            this.groupBoxIn_SAH.Location = new System.Drawing.Point(12, 72);
            this.groupBoxIn_SAH.Name = "groupBoxIn_SAH";
            this.groupBoxIn_SAH.Size = new System.Drawing.Size(381, 319);
            this.groupBoxIn_SAH.TabIndex = 1;
            this.groupBoxIn_SAH.TabStop = false;
            this.groupBoxIn_SAH.Text = "Ввод: ";
            // 
            // openFileDialog_SAH
            // 
            this.openFileDialog_SAH.FileName = "openFileDialog1";
            // 
            // buttonHelp_SAH
            // 
            this.buttonHelp_SAH.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_SAH.Image")));
            this.buttonHelp_SAH.Location = new System.Drawing.Point(719, 5);
            this.buttonHelp_SAH.Name = "buttonHelp_SAH";
            this.buttonHelp_SAH.Size = new System.Drawing.Size(69, 47);
            this.buttonHelp_SAH.TabIndex = 1;
            this.buttonHelp_SAH.UseVisualStyleBackColor = true;
            this.buttonHelp_SAH.Click += new System.EventHandler(this.buttonHelp_SAH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOsnova_SAH);
            this.Controls.Add(this.panelTopSide_SAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Солиев А.Х.";
            this.panelTopSide_SAH.ResumeLayout(false);
            this.panelOsnova_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.ResumeLayout(false);
            this.groupBoxTask_SAH.PerformLayout();
            this.groupBoxOutput_SAH.ResumeLayout(false);
            this.groupBoxOutput_SAH.PerformLayout();
            this.groupBoxIn_SAH.ResumeLayout(false);
            this.groupBoxIn_SAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopSide_SAH;
        private System.Windows.Forms.Button buttonDone_SAH;
        private System.Windows.Forms.Button buttonOpen_SAH;
        private System.Windows.Forms.Panel panelOsnova_SAH;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAH;
        private System.Windows.Forms.TextBox textBoxOutPut_SAH;
        private System.Windows.Forms.GroupBox groupBoxIn_SAH;
        private System.Windows.Forms.TextBox textBoxInPut_SAH;
        private System.Windows.Forms.GroupBox groupBoxTask_SAH;
        private System.Windows.Forms.TextBox textBoxTask_SAH;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SAH;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonHelp_SAH;
    }
}


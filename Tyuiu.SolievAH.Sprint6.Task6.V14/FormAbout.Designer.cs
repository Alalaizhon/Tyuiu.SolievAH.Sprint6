
namespace Tyuiu.SolievAH.Sprint6.Task6.V14
{
    partial class FormAbout_SAH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SAH));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelInfo_SAH = new System.Windows.Forms.Label();
            this.buttonOK_SAH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelInfo_SAH
            // 
            this.labelInfo_SAH.AutoSize = true;
            this.labelInfo_SAH.Location = new System.Drawing.Point(189, 9);
            this.labelInfo_SAH.Name = "labelInfo_SAH";
            this.labelInfo_SAH.Size = new System.Drawing.Size(284, 143);
            this.labelInfo_SAH.TabIndex = 1;
            this.labelInfo_SAH.Text = resources.GetString("labelInfo_SAH.Text");
            // 
            // buttonOK_SAH
            // 
            this.buttonOK_SAH.Location = new System.Drawing.Point(398, 155);
            this.buttonOK_SAH.Name = "buttonOK_SAH";
            this.buttonOK_SAH.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SAH.TabIndex = 2;
            this.buttonOK_SAH.Text = "OK";
            this.buttonOK_SAH.UseVisualStyleBackColor = true;
            this.buttonOK_SAH.Click += new System.EventHandler(this.buttonOK_SAH_Click);
            // 
            // FormAbout_SAH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 198);
            this.Controls.Add(this.buttonOK_SAH);
            this.Controls.Add(this.labelInfo_SAH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_SAH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelInfo_SAH;
        private System.Windows.Forms.Button buttonOK_SAH;
    }
}
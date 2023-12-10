
namespace Tyuiu.SolievAH.Sprint6.Task7.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_SAH = new System.Windows.Forms.Button();
            this.labelInfo_SAH = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SAH
            // 
            this.buttonOK_SAH.Location = new System.Drawing.Point(395, 155);
            this.buttonOK_SAH.Name = "buttonOK_SAH";
            this.buttonOK_SAH.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_SAH.TabIndex = 5;
            this.buttonOK_SAH.Text = "OK";
            this.buttonOK_SAH.UseVisualStyleBackColor = true;
            this.buttonOK_SAH.Click += new System.EventHandler(this.buttonOK_SAH_Click);
            // 
            // labelInfo_SAH
            // 
            this.labelInfo_SAH.AutoSize = true;
            this.labelInfo_SAH.Location = new System.Drawing.Point(186, 9);
            this.labelInfo_SAH.Name = "labelInfo_SAH";
            this.labelInfo_SAH.Size = new System.Drawing.Size(284, 156);
            this.labelInfo_SAH.TabIndex = 4;
            this.labelInfo_SAH.Text = resources.GetString("labelInfo_SAH.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 147);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 182);
            this.Controls.Add(this.buttonOK_SAH);
            this.Controls.Add(this.labelInfo_SAH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_SAH;
        private System.Windows.Forms.Label labelInfo_SAH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
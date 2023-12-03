using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SolievAH.Sprint6.Task2.V12.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SAH.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SAH.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_SAH.Titles.Add("График функции");
                this.chartFunction_SAH.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAH.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SAH.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_SAH.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonDone_SAH_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SAH.BackColor = Color.Red;
        }

        private void buttonDone_SAH_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SAH.BackColor = Color.Green;
        }

        private void buttonDone_SAH_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SAH.BackColor = Color.Blue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SolievAH.Sprint6.Task5.V23.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\katag\source\repos\Tyuiu.SolievAH.Sprint6\Tyuiu.SolievAH.Sprint6.Task5.V23\bin\Debug\InPutFileTask5V23.txt";

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SAH.ColumnCount = 2;
            dataGridViewResult_SAH.Columns[0].Width = 20;
            dataGridViewResult_SAH.Columns[1].Width = 50;

            this.chartFunction_SAH.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_SAH.ChartAreas[0].AxisX.Title = "Ось Y";

            chartFunction_SAH.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_SAH.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_SAH.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenF_SAH_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

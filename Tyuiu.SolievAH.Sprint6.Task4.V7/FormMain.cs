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
using Tyuiu.SolievAH.Sprint6.Task4.V7.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task4.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SAH_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
            File.WriteAllText(path, textBoxResult_SAH.Text);

            DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно! \nоткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBoxStartStep_SAH.Text);
            int endStep = Convert.ToInt32(textBoxStopStep_SAH.Text);

            double[] valueArr = ds.GetMassFunction(startStep, endStep);

            this.chartFunction_SAH.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_SAH.ChartAreas[0].AxisY.Title = "Ось Y";

            textBoxResult_SAH.Text = "";

            chartFunction_SAH.Series[0].Points.DataBindY(valueArr); // Обновление графика

            for (int i = 0; i < valueArr.Length; i++)
            {
                textBoxResult_SAH.AppendText(valueArr[i] + Environment.NewLine);
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SolievAH.Sprint6.Task1.V20.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void ButtonDone_SAH_Click(object sender, EventArgs e)
        {
            try
            {


                int startstep = Convert.ToInt32(textBoxStartStep_SAH.Text);
                int stopstep = Convert.ToInt32(textBoxStopStep_SAH.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_SAH.Text = "";
                textBoxResult_SAH.AppendText("+-------------------------+" + Environment.NewLine);
                textBoxResult_SAH.AppendText("|    x     |     f(x)     |" + Environment.NewLine);
                textBoxResult_SAH.AppendText("+-------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startstep, func[i]);
                    textBoxResult_SAH.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_SAH.AppendText("+-------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

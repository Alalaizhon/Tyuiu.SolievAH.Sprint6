using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SolievAH.Sprint6.Task0.V30.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task0.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРБ-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPushMe_SAH_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_SAH.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SAH.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неправильные данные");
            }


        
        }
    }
}

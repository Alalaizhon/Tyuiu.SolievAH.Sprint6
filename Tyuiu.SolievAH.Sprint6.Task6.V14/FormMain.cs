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
using Tyuiu.SolievAH.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SolievAH.Sprint6.Task6.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string OpenFilePath;
        DataService ds = new DataService();
        
        private void buttonOpen_SAH_Click(object sender, EventArgs e)
        {
            openFileDialog_SAH.ShowDialog();
            OpenFilePath = openFileDialog_SAH.FileName;
            textBoxInPut_SAH.Text = File.ReadAllText(OpenFilePath);
            groupBoxOutput_SAH.Text = groupBoxOutput_SAH.Text + " " + openFileDialog_SAH.FileName;
            buttonDone_SAH.Enabled = true;
        }

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SAH.Text = ds.CollectTextFromFile(OpenFilePath);
        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            FormAbout_SAH formAbout = new FormAbout_SAH();
            formAbout.ShowDialog();
        }
    }
}

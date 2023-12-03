using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SolievAH.Sprint6.Task3.V21.Lib;
namespace Tyuiu.SolievAH.Sprint6.Task3.V21
{
    public partial class FormMain_SAH : Form
    {
        public FormMain_SAH()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 26 , -15, 7,  1,   -4 },
                                        {14, 26,  22,  17,  27 },
                                        {-8,  31, 22, 34,  4 },
                                        {-18,  16,  -2 , 16, 27 },
                                        {5,  2,  -4,   16,   15 } };

        private void buttonDone_SAH_Click(object sender, EventArgs e)
        {
            int[,] matrX = ds.Calculate(matrix);
            int rows = matrX.GetUpperBound(0) + 1;
            int columns = matrX.Length / rows;

            dataGridViewMatrix_SAH.ColumnCount = columns;
            dataGridViewMatrix_SAH.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SAH.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAH.Rows[i].Cells[j].Value = Convert.ToString(matrX[i, j]);
                }
            }

        }

        private void buttonHelp_SAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Солиев Алижон Хотамжонович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_SAH_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_SAH.ColumnCount = columns;
            dataGridViewMatrix_SAH.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SAH.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SAH.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}

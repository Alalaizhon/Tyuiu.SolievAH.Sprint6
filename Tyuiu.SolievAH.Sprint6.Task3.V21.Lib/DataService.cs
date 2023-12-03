using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SolievAH.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;


            int[] list = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                list[i] = matrix[i, 0];
            }
            Array.Sort(list);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 0] = list[i];
            }
            return matrix;
        }
    }
}

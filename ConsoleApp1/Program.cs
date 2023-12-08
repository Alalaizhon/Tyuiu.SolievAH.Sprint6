using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint6.Task4.V7.Lib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double a = Math.Cos(-5) / -5 + 2;
            double b = 3 * -5;
            double y = Math.Cos(-5) + a - b;
            Console.WriteLine(y);

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}

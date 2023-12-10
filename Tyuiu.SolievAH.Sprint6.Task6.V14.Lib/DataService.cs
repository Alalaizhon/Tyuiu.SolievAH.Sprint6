using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SolievAH.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.Contains("z"))
                        {
                            resStr = resStr + " " + word;
                        }
                    }

                }
            }
            return resStr;

            
        }
    }
}

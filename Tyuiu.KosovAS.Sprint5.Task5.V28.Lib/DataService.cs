using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.Collections;

namespace Tyuiu.KosovAS.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            double result = 1;
            double minNum = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                List<double> minArray = new List<double>();
                while ((line = reader.ReadLine()) != null)
                {

                    if (Convert.ToDouble(line) > 0 && Convert.ToDouble(line) % 5 == 0)
                    {
                        minArray.Add(Convert.ToDouble(line));
                    }
                }
                minNum = minArray.Min();
                for (int i = 1; i <= minNum; i++)
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}

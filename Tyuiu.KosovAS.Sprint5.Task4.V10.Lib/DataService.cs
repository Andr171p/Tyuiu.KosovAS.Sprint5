using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosovAS.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double X = Convert.ToDouble(strX.Replace('.', ','));
            double result = Math.Round((Math.Pow(X, 4) * 1.2 + 2), 3);

            return result;
        }
    }
}

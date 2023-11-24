using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosovAS.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] charsToRemove = new string[5] { "?", ",", ".", ";", "'" };
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }
                    string[] lineArray = line.Split(' ');
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        if (lineArray[i].Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;

        }
    }
}

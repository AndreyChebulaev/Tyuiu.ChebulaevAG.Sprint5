using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChebulaevAG.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    int allSpaces = 0;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        allSpaces += CountConsecutiveSpaces(line);
                    }

                    return allSpaces;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                return -1;
            }
        }

        private int CountConsecutiveSpaces(string line)
        {
            int res = 0;
            int now = 0;

            foreach (char c in line)
            {
                if (c == ' ')
                {
                    now++;
                }
                else
                {
                    if (now > 1)
                    {
                        res += now;
                    }
                    now = 0;
                }
            }

            return res;
        }
    }
}

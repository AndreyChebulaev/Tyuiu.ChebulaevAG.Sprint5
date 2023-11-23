using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChebulaevAG.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    double maxPrime = double.MinValue;

                    while ((line = reader.ReadLine()) != null)
                    {
                        double number = Convert.ToDouble(line);

                        double roundedNumber = Math.Round(number, 3);

                        if (roundedNumber % 1 == 0)
                        {
                            if (IsPrime(roundedNumber) && roundedNumber > maxPrime)
                            {
                                maxPrime = roundedNumber;
                            }
                        }
                    }

                    return maxPrime;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return double.NaN; 
            }
        }

        private static bool IsPrime(double number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}

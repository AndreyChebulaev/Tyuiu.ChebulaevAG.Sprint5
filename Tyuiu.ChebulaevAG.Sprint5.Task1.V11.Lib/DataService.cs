using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ChebulaevAG.Sprint5.Task1.V11.Lib
{
    public class DataService : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("x\t\tf(x)");

                    for (double x = startValue; x <= stopValue; x += 1)
                    {
                        try
                        {
                            double numerator = Math.Sin(x) - 2 * x;
                            double denominator = 3 * x - 1;

                            if (denominator == 0)
                            {
                                throw new DivideByZeroException();
                            }

                            double result = numerator / denominator + Math.Sin(x) - 3 * x + 2;
                            writer.WriteLine($"{x}\t\t{result:F2}");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine($"Внимание: Деление на ноль при x = {x}. Значение заменено на 0.");
                            writer.WriteLine($"{x}\t\t{0:F2}");
                        }
                    }
                }

                Console.WriteLine("Табуляция успешно завершена. Результат сохранен в файл: " + path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            return path;
        }
    }
}

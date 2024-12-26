using System;
using System.Text;

namespace Tyuiu.OsadetsAA.Sprint7.V7.Lib
{
    
    public class DataService
    {
        public static List<double> LoadAreasFromCsv(string filePath)
        {
            var areas = new List<double>();

            try
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var columns = line.Split(';');

                        // Проверка на наличие второго столбца и преобразование в целое число
                        if (columns.Length > 2 && double.TryParse(columns[2], out double area))
                        {
                            areas.Add(area);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке данных: {ex.Message}");
                throw;
            }

            return areas;
        }
        public static double CalculateAverageArea(List<double> areas)
        {
            if (areas == null || areas.Count == 0)
                throw new ArgumentException("Список площадей пуст или не задан.");
            
            double sum = 0;
            foreach (var area in areas)
            {
                sum += area;
            }

            return Math.Round(sum / areas.Count, 3);
        }
        public static double CalculateMinArea(List<double> areas)
        {
            if (areas == null || areas.Count == 0)
                throw new ArgumentException("Список площадей пуст или не задан.");

            double minArea = areas[0];

            foreach (var area in areas)
            {
                if (area < minArea)
                {
                    minArea = area;
                }
            }

            return minArea;
        }
        public static double CalculateMaxArea(List<double> areas)
        {
            if (areas == null || areas.Count == 0)
                throw new ArgumentException("Список площадей пуст или не задан.");

            double maxArea = areas[0];

            foreach (var area in areas)
            {
                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }
    }
}

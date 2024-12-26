using System.Text;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.BilousEYu.Sprint7.Project.V9.Lib
{
    public class DataService
    {
            private readonly string filePath;

        public DataService()
        {
        }

        public DataService(string path)
            {
                filePath = path;
            }

            public List<VideoTape> LoadData()
            {
                var videoList = new List<VideoTape>();

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("CSV file not found.", filePath);
                }

                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');
                        if (values.Length != 5) continue;

                        try
                        {
                            videoList.Add(new VideoTape
                            {
                                Code = values[0],
                                Date = DateTime.Parse(values[1]),
                                Duration = int.Parse(values[2]),
                                Theme = values[3],
                                Cost = decimal.Parse(values[4])
                            });
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error parsing line: {line}. Error: {ex.Message}");
                        }
                    }
                }

                return videoList;
            }

            public void SaveData(List<VideoTape> videoList)
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var video in videoList)
                    {
                        writer.WriteLine(video.ToString());
                    }
                }
            }
    }
}


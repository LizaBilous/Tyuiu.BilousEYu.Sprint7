namespace Tyuiu.BilousEYu.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        static string DBFilePath = $@"{Directory.GetCurrentDirectory()}\Playlist.txt";

        public bool SaveInfo(int m, int s, int h, string desc, string FilePath, string FileName)
        {
            try
            {

                if (!IsExists(FilePath))
                {
                    string set = FilePath + ";" + FileName + ";" + h + ";" + m + ";" + s + ";" + desc + "\n";
                    File.AppendAllText(DBFilePath, set);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public string[,] GetInfo()
        {
            //File.Create(DBFilePath);
            string[] data = File.ReadAllLines(DBFilePath);
            string[,] all_data = new string[data.Length, 6];
            for (int i = 0; i < all_data.GetLength(0); i++)
            {
                string[] asd = data[i].Split(';');
                for (int j = 0; j < all_data.GetLength(1); j++)
                {
                    all_data[i, j] = asd[j];
                }
            }
            return all_data;
        }


        public bool IsExists(string FilePath)
        {
            string[,] data = GetInfo();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == FilePath)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool DeleteInfo(int row)
        {
            try
            {
                string[,] data = GetInfo();
                string[] new_info = new string[data.GetLength(0) - 1];
                int g = 0;
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    if (i != row)
                    {
                        new_info[g] = data[i, 0] + ";" + data[i, 1] + ";" + data[i, 2] + ";" + data[i, 3] + ";" + data[i, 4] + ";" + data[i, 5];
                        g++;
                    }
                }
                File.Delete(DBFilePath);
                File.AppendAllLines(DBFilePath, new_info);
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}

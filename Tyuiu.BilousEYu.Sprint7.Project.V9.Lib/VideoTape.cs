namespace Tyuiu.BilousEYu.Sprint7.Project.V9.Lib
{
    public class VideoTape
    {
        public string Code { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; } 
        public string Theme { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $"{Code},{Date.ToString("GG-MM-DD")},{Duration},{Theme},{Cost}";
        }
    }
}
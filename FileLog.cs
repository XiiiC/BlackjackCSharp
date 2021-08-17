using System;
using System.IO;
using System.Text;

namespace BlackJackCSharp
{
    public class FileLog
    {
        private StringBuilder Log = new StringBuilder();

        public void LogLine(string x)
        {
            Log.AppendLine(x);
            Console.WriteLine(x);
        }
        public void SaveLog()
        {
            string file = DateTime.Now.ToString("ddMMyy_HHmmss_fff") + "_log.txt";
            //Chnaged from Path.Join to Path.Combine, hopefully fix, if logging fails look here
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), file);
            Console.WriteLine($"Saved to {filePath}");
            File.WriteAllText(filePath, Log.ToString());
        }
    }
}

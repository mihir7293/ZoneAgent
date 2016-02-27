using System;
using System.IO;
namespace ZoneAgent
{
    /// <summary>
    /// class that is use to write logs
    /// </summary>
    class Logger
    {
        static StreamWriter sw;
        /// <summary>
        /// Write logs to file
        /// </summary>
        /// <param name="fileName">filename to which log is to be written</param>
        /// <param name="log">log text to be written to file</param>
        public static void Write(string fileName,string log)
        {
            try
            {
                if (!Directory.Exists("./logs"))
                    Directory.CreateDirectory("./logs");
                sw = new StreamWriter("./logs/"+fileName, true);
                sw.WriteLine("["+DateTime.Now.Year+"/"+DateTime.Now.Month+"/"+DateTime.Now.Day+"-"+DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second+"] "+log);
                sw.Close();
            }
            catch
            {
            }
        }
        /// <summary>
        /// Generate filename based on date and time and filename received
        /// </summary>
        /// <param name="fileName">name of file</param>
        /// <returns>filename</returns>
        public static string GetLoggerFileName(string fileName)
        {
            return +DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"@"+DateTime.Now.Hour+"-"+DateTime.Now.Minute+"-"+DateTime.Now.Second+"_"+fileName+".log";
        }
        /// <summary>
        /// To write byte[] to file
        /// </summary>
        /// <param name="filename">filename</param>
        /// <param name="data">byte[] data</param>
        public static void WriteBytes(string filename,byte[] data)
        {
            File.WriteAllBytes(filename, data);
        }
    }
}

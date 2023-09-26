using System;
using System.IO;

namespace WindBot
{
    public static class Logger
    {
        public static void WriteLine(string message)
        {
            WriteErrorLog("[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
        }
        public static void DebugWriteLine(string message)
        {
            WriteErrorLog("[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
        }
        public static void WriteErrorLine(string message)
        {
            WriteErrorLog("[" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "] " + message);
        }
        public static void WriteErrorLog(string message)
        {
            if (File.Exists("WindBot/debug.log"))
            {
                using (StreamWriter file = new StreamWriter("WindBot/debug.log", true))
                {
    　　            file.WriteLine(message);
                }
            }
        }
    }
}
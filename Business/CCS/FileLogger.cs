using System;
using Business.CCS;

namespace Business.CCS
{
    public class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}


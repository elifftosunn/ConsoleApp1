using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // bu class ILoggerService alternatifidir.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}

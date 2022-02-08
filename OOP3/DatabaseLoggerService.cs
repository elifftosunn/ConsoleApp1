using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface == service
    class DatabaseLoggerService : ILoggerService // bu class ILoggerService alternatifidir.
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface'ler de o interface'i implemente eden class'ın referans numarasını tutabiliyor.
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager transportLoanManager = new TransportLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager artisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //veritabanına logladık ///2.YOL
            ILoggerService fileLoggerService = new FileLoggerService(); //dosyaya logladık
            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.makeApplication(needCreditManager, new DatabaseLoggerService());//veritabanına logladık


            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() }; //kendi log listemizi oluşturduk

            applicationManager.makeApplication(needCreditManager,loggers);//dosyaya ve sms'e logladık(birden fazla loglama işlemi)
            //applicationManager.makeApplication(artisanLoanManager, databaseLoggerService);//veritabanına logladık
            //applicationManager.makeApplication(new ArtisanLoanManager(), new SmsLoggerService());//sms'e logladık

           
            
            
            List<ICreditManager> credits = new List<ICreditManager> { needCreditManager, transportLoanManager, housingLoanManager };

            //applicationManager.creditPreNotification(credits);//bankadaki görevli kredi ön bilgilendirmesi yapması için kredileri yolladı.


        }

    }
}

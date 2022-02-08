using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager transportLoanManager = new TransportLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();
            ICreditManager artisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService(); 
            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.makeApplication(needCreditManager, new DatabaseLoggerService());


            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() }; 

            applicationManager.makeApplication(needCreditManager,loggers);
            //applicationManager.makeApplication(artisanLoanManager, databaseLoggerService);
            //applicationManager.makeApplication(new ArtisanLoanManager(), new SmsLoggerService());

           
            
            
            List<ICreditManager> credits = new List<ICreditManager> { needCreditManager, transportLoanManager, housingLoanManager };
            //applicationManager.creditPreNotification(credits);
        }

    }
}

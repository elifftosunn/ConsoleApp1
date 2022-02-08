using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager 
    {
        public void makeApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices) 
            {
                loggerService.Log(); 
            }
        }
        public void creditPreNotification(List<ICreditManager> credits) 
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager 
    {
        public void makeApplication(ICreditManager creditManager,List<ILoggerService> loggerServices) //burada tek bir kredi istiyor
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices) 
            {
                loggerService.Log(); 
            }
        }
        public void creditPreNotification(List<ICreditManager> credits) //burada birden fazla kredi sunuyorsun 1 de olabilir 1000 de
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}

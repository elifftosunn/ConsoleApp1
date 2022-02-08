using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager //Başvuru İşlemleri
    {
        //buraya hangi krediyi gönderirsem o kredi hesaplanır yani parametreye konut kredisi gönderirsem konut hesaplarnı,taşıt gönderirsem taşıt hesaplanır.
        public void makeApplication(ICreditManager creditManager,List<ILoggerService> loggerServices) //burada tek bir kredi istiyor
        {
            //Başvuran bilgilerini değerlendirme
            //Kredi Hesaplama
            creditManager.Calculate();
            //loggerService.Log();  //loglama tek olduğu zaman
            foreach (var loggerService in loggerServices) //birden fazla loglama olduğu zaman
            {
                loggerService.Log(); // her bir loglayıcığı çalıştır dedik
            }
        }
        //kredi ön bilgilendirmesi
        public void creditPreNotification(List<ICreditManager> credits) //burada birden fazla kredi sunuyorsun 1 de olabilir 1000 de
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}

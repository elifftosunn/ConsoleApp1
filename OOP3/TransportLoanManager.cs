using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TransportLoanManager : ICreditManager //Taşıt Kredisi Yönetimi
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}

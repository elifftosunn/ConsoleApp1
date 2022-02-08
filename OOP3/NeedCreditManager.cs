using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICreditManager //İhtiyaç Kredisi
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}

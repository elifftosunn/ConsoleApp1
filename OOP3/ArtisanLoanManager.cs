using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ICreditManager //Esnaf Kredisi
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}

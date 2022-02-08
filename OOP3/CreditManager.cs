using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // okunurluğu arttırmak için interface'leri I harfi ile başlatırız.
    // bankadaki her kredide olması gereken metotlar olduğundan ve her kredi için hesap farklı olduğundan interface olarak tanımlarız.

    //interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    interface ICreditManager //interface => şablon görevi görür
    {
        void Calculate();
        void BiseyYap();
        
    }
}

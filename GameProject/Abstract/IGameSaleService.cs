using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void GameSales(Gamer gamer,Game game,Campaign campaign);  //oyun satışı
    }
}

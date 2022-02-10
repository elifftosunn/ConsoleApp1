using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : IGameSaleService
    {
        public void GameSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+" "+campaign.CampaignName+" kampanya ile "+game.GameName+" isimli oyunu "+game.UnitPrice+" TL yerine "+game.DiscountedPrice+" TL'ye satın aldı.");
        }
    }
}

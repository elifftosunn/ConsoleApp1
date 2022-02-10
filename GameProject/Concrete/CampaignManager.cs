using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void AddCampaing(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya eklendi.");
        }

        public void DeleteCamping(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya silindi.");
        }

        public void UpDateCampaing(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya güncellendi.");
        }
    }
}

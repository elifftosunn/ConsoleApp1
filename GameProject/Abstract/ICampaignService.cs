using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void AddCampaing(Campaign campaign);
        void DeleteCamping(Campaign campaign);
        void UpDateCampaing(Campaign campaign);
    }
}

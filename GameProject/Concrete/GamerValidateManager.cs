using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Adapters;

namespace GameProject.Concrete
{
    public class GamerValidateManager : IGamerValidateService
    {
        IGamerValidateService gamerValidateService;
        public bool CheckIfRealPerson(Gamer gamer)
        {
            gamerValidateService = new MernisServiceAdapter();
            return gamerValidateService.CheckIfRealPerson(gamer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;


namespace GameProject.Abstract
{
    public interface IGamerValidateService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}

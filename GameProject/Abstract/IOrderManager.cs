using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderManager
    {
        void Promotion(Player username, Game Name, Promotion promo);
        void GameSale(Player username, Game Name,);
    
    }
}

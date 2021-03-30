using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class PlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine(player.UserName + " succesfully deleted.! ");
        }

        public void Save(Player player)
        {
            Console.WriteLine(player.UserName + "succesfully added!");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.UserName + "succesfully updated.!" );
        }
    }
}

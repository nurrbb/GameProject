using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player();
            player1.UserName = "Saint";
            player1.Name = "John";
            player1.Surname = "Watson";
            player1.SSNumber = "327556";
            player1.BirthYear = "1968";

            Promotion Discount1 = new Promotion();
            Discount1.Id = 367;
            Discount1.Name = "Detroit";
            Discount1.PromotionCountdown = "5 April!!";
            Discount1.Description = "10% save!";

            










        }
    }
}

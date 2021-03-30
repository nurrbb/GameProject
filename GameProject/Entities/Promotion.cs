using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Promotion : IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string PromotionCountdown { get; set; }

    }
}

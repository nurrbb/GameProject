using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Player: IEntity
    {
        public string UserName { get; set; }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SSNumber { get; set; } //social security number
        public string BirthYear { get; set; }
       
    }
}

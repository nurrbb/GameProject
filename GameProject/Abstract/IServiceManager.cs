using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IServiceManager
    {
        void New(Promotion Promo);
        void Delete(Promotion Promo);
        void Update(Promotion Promo);
    }
}

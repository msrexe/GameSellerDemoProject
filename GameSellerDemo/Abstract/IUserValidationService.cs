using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

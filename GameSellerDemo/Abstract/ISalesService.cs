using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void SaleswithCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}

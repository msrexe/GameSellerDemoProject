using GameSellerDemo.Abstract;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.Name + " kullanıcısına "+game.GameName + " isimli oyunun "+ game.GamePrice + "fiyattan satışı başarılı");
        }

        public void SaleswithCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            decimal discountedPrice = game.GamePrice - (game.GamePrice * campaign.Discount);
            Console.WriteLine(gamer.Name + " kullanıcısına " + game.GameName + " isimli oyunun " + game.GamePrice 
                + "fiyattan satışı başarılı. Uygulanan kampanya : "+campaign.CampaignName);
        }
    }
}

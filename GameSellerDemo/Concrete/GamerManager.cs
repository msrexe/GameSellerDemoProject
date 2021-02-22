using GameSellerDemo.Abstract;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.Name + " isimli kullanıcı eklendi");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulaması başarısız !!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " isimli kullanıcı silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " isimli kullanıcı güncellendi");
        }
    }
}

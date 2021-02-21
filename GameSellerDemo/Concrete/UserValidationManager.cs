using GameSellerDemo.Abstract;
using GameSellerDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellerDemo.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            //DOğrulama işlemleri
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(gamer.NationalID,gamer.Name,gamer.Surname,gamer.DateOfBirth)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

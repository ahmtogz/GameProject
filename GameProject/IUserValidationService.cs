using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Kullanici dogrulama servisi
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
        //// void yerine bool yazdik return döndürmek icin
    }
}

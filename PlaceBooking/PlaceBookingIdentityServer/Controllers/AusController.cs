using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceBookingIdentityServer.Controllers
{
    public class AusController : Controller
    {
        //login Post(login, password) - Get User - find by Name(UserManager) - checkPassword - generation access/refresh token and add token(return tokens) - моделька щоб приймати старі токени, берем id з claims і шукаємо user і зрівнюємо рефреш токени і виклик рефрешу

        //refresh Post()
    }
}

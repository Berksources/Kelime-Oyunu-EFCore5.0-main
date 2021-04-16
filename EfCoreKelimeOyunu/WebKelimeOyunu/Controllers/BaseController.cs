using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace WebKelimeOyunu.Controllers
{
    public class BaseController : Controller
    {
        public int getCurrentUser()
        {
            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Convert.ToInt32(userID);
        }

        public string getCurrentUserClaimRole()
        {
            return User.FindFirstValue(ClaimTypes.Role);
        }

        public string getCurrentUserName()
        {
            return User.Identity.Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MauiApp3.Models
{
    public static class ApiCallerUri
    {
        //private const string domainBody = "http://127.0.0.1:8000/api/";
        private const string domainBody = "https://djangorestapiv3.azurewebsites.net/api/";

        //API päätepisteet
        public const string Login = $"{domainBody}login/";
        public const string Logout = $"{domainBody}logout/";
        public const string Users = $"{domainBody}users/";
        public const string Profile = $"{domainBody}profile/";
        public const string Posts = $"{domainBody}posts/";
        public const string Comment = $"{domainBody}comments/";
        public const string Likes = $"{domainBody}likes/";
        public const string Signup = $"{domainBody}signup/";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    public static class ApiCallerUri
    {   
        //API päätepisteet
        public const string Login = "https://djangorestapiv3.azurewebsites.net/api/login/";
        public const string Logout = "https://djangorestapiv3.azurewebsites.net/api/logout/";
        public const string Users = "https://djangorestapiv3.azurewebsites.net/api/users/";
        public const string Posts = "https://djangorestapiv3.azurewebsites.net/api/posts/";
        public const string Comment = "https://djangorestapiv3.azurewebsites.net/api/comments/";
        public const string Likes = "https://djangorestapiv3.azurewebsites.net/api/likes/";
    }
}

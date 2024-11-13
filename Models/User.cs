﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Models
{
    public class User
    {
        public int? id { get; set; }
        public string? username { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool ShowAlert { get; set; }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_3_BasicAuthenticationWEBAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
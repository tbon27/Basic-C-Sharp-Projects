﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAppMVC.Models
{
    public class User
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
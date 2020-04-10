﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab23.DAL.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Item> Cart = new List<Item>();
        public double Wallet { get; set; }
    }
}

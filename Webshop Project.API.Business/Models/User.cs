﻿namespace Webshop_Project.API.Business.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string[] Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int BasketID { get; set; }
        public Basket Basket { get; set; }
    }
}
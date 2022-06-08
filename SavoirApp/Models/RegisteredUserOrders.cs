﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavoirApp.Models
{
    public class RegisteredUserOrders
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("RegisteredUsers")]
        public int IDRegisteredUser { get; set; }
        public RegisteredUser RegisteredUser { get; set; }

        [ForeignKey("Orders")]
        public int IDOrder { get; set; }
        public Order Order { get; set; }

        public RegisteredUserOrders()
        {
        }
    }
}
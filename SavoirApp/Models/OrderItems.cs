﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SavoirApp.Models
{
    public class OrderItems
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Orders")]
        public int IDOrder { get; set; }
        public Order Order { get; set; }

        [ForeignKey("Items")]
        public int IDItem { get; set; }
        public Item item { get; set; }

        public OrderItems()
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Models
{
    public class Customer
    {
        //set the primary key
        [Key]
        public int CustomerId { get; set; }

        public string Name { get; set; }
        public string Account { get; set; }
        public string Address { get; set; }

        //set one to many relationship
        public ICollection<Order> Orders { get; set; }
    }
}

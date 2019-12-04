using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Models
{
    public class Order
    {
        //set the primary key
        [Key]
        public int OrderId { get; set; }
        //set the foreign key
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public string FoodType { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        //one order only belong to one customer
        public Customer Customers { get; set; }
    }
    
}

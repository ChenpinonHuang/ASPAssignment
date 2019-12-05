using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPAssignment.Models;

namespace ASPAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPAssignment.Models.Customer> Customer { get; set; }
        public DbSet<ASPAssignment.Models.Order> Order { get; set; }
        
    }
}

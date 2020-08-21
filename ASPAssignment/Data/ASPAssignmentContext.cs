using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPAssignment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ASPAssignment.Models
{
    public class ASPAssignmentContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ASPAssignmentContext (DbContextOptions<ASPAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<ASPAssignment.Models.Customer> Customer { get; set; }

        public DbSet<ASPAssignment.Models.Order> Order { get; set; }
    }
}

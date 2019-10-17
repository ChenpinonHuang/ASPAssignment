using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASPAssignment.Models;

namespace ASPAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPAssignment.Models.TerrestrialAnimal> TerrestrialAnimal { get; set; }
        public DbSet<ASPAssignment.Models.Animal> Animal { get; set; }
    }
}

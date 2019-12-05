using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;

        }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

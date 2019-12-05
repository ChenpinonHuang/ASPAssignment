using ASPAssignment.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment.Data
{
    public class SeedRoles
    {
        public static async Task CreateRoles(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administration role";

            string role2 = "Member";
            string desc2 = "This is the members role";

            string password = "Admin@2019";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }

            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("admin@test.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@test.com",
                    Email = "admin@test.com",
                    PhoneNumber = "4162551234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }

                adminId1 = user.Id;
            }
        }
    
     }
}

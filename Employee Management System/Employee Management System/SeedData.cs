using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    // In C# when we make a class static it means that we can call the whatever element of the class
    // without having to initialize an object of the class. When the class is static then everything else needs
    // to be static.
    public static class SeedData
    {
        public static void Seed(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRole(roleManager);
            SeedUser(userManager);
        }
        public static void SeedUser(UserManager<IdentityUser> userManager)
        {
            if(userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@localhost.com",
                    Email = "admin@localhost.com"
                };

                var result = userManager.CreateAsync(user, "Password.1").Result;

                // if succed then syncron with the role Administrator.
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }
        public static void SeedRole(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Employee"
                };

                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}

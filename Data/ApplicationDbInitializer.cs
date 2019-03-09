using System;
using crushtown_heroes_API.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace crushtown_heroes_API.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = new string[]
            {
                "Game Master",
                "Game Sage",
                "Member"
            };

            foreach(string role in roles)
            {
                if (roleManager.FindByNameAsync(role).Result==null)
                {
                    IdentityRole roleToAdd = new IdentityRole
                    {
                        Name = role
                    };

                    IdentityResult result = roleManager.CreateAsync(roleToAdd).Result;
                }      
            }
        }   

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            string[] admins = new string[]
            {
                "kallie@nextborder.xyz",
                "thilun@nextborder.xyz",
                "aelly@nextborder.xyz"
            };

            foreach(string admin in admins)
            {
                if (userManager.FindByEmailAsync(admin).Result==null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        UserName = admin,
                        Email = admin
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa$$w0rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Game Master").Wait();
                    }
                }      
            }
        }   
    }
}
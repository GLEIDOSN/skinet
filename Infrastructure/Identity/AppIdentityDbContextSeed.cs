using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Gleidson",
                    Email = "fc_gleidson@hotmail.com",
                    UserName = "fc_gleidson@hotmail.com",
                    Address = new Address
                    {
                        FirstName = "Francisco",
                        LastName = "Gleidson",
                        Street = "Rua tal",
                        City = "Caucaia",
                        State = "CE",
                        Zipcode = "61610090"
                    }
                };

                await userManager.CreateAsync(user, "P@$$w0rd123456");
            }
        }
    }
}
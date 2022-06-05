using BlueNet.Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlueNet.Api.Data
{
    public class BlueNetDbContextSeed
    {
        private readonly IPasswordHasher<User> _passwordHasher = new PasswordHasher<User>();

        public async Task SeedAsync(BlueNetDbContext context, ILogger<BlueNetDbContextSeed> logger)
        {
            if (!context.Users.Any())
            {
                var user1 = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN1@GMAIL.COM",
                    UserName = "admin",
                    FirstName = "Mr",
                    LastName = "A",
                    NormalizedUserName = "ADMIN",
                    SecurityStamp = Guid.NewGuid().ToString()

                };
                user1.PasswordHash = _passwordHasher.HashPassword(user1, "123456");
                context.Users.Add(user1);

                var user2 = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "nva@gmail.com",
                    NormalizedEmail = "NVA1@GMAIL.COM",
                    UserName = "nva",
                    FirstName = "Ng",
                    LastName = "VA",
                    NormalizedUserName = "NVA",
                    SecurityStamp = Guid.NewGuid().ToString()

                };
                user2.PasswordHash = _passwordHasher.HashPassword(user2, "123456");
                context.Users.Add(user2);
            }

            if (!context.BlackLists.Any())
            {
                context.BlackLists.Add(new Entities.BlackList()
                {
                    BlackListId = Guid.NewGuid(),
                    Url = "www.com",
                });
            }

            await context.SaveChangesAsync();
        }
    }
}

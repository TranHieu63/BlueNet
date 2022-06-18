using BlueNet.Api.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlueNet.Api.Data
{
    public class BlueNetDbContext : IdentityDbContext<User, Role, Guid>
    {
        public BlueNetDbContext(DbContextOptions<BlueNetDbContext> options) : base(options) 
        { 
        }

        public DbSet<BlackList> BlackLists { get; set; }
         

        public DbSet<Violation> Violations { get; set; }
         

    }
}

﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPIDiscussion.Database
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

    }
}

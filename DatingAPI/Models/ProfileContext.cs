using System;
using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Models
{
    public class ProfileContext:DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
    }
}

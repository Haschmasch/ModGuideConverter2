using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModGuideConverter2.Core.Models;

namespace ModGuideConverter2.Data
{
    public class DatabaseContext : IdentityDbContext<ConverterUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<RootDirectory> RootDirectories { get; set; }

        public DbSet<ModuleGuideDirectory> ModuleGuideDirectories { get; set; }

        public DbSet<UserModuleGuideMapping> UserModuleGuideMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeed());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Data;

namespace RANUISWANSONFOOTBALLCLUB_WEBSITEContext
{
    public class db : IdentityDbContext
    {
        public class IdentityDbContextEntityConfiguration : IEntityTypeConfiguration<IdentityDbContext>
        {
            public object FirstName { get; private set; }
            public object LastName { get; private set; }

            public void Configure(EntityTypeBuilder<IdentityDbContext> builder)
            {
                builder.Property(User => FirstName).HasMaxLength(225);
                builder.Property(User => LastName).HasMaxLength(225);
            }
        }

        public db(DbContextOptions<db> options)
            : base(options)
        {
        }
        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Coach> Coach { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Manager> Manager { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Player> Player { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Position> Position { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Transaction> Transaction { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Team> Team { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Data.User> User { get; set; } = default!;
    }
}

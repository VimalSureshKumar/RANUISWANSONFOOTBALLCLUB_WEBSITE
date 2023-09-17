﻿using System;
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
        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Coaches> Coaches { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Managers> Managers { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Players> Players { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Positions> Positions { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Transactions> Transactions { get; set; } = default!;
    }
}

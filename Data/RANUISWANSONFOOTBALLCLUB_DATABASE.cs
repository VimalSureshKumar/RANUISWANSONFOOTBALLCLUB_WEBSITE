using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RANUISWANSONFOOTBALLCLUB_WEBSITE.Models;

    public class RANUISWANSONFOOTBALLCLUB_DATABASE : DbContext
    {
        public RANUISWANSONFOOTBALLCLUB_DATABASE (DbContextOptions<RANUISWANSONFOOTBALLCLUB_DATABASE> options)
            : base(options)
        {
        }

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Coaches> Coaches { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Managers> Managers { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Players> Players { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Positions> Positions { get; set; } = default!;

        public DbSet<RANUISWANSONFOOTBALLCLUB_WEBSITE.Models.Transactions> Transactions { get; set; } = default!;
    }

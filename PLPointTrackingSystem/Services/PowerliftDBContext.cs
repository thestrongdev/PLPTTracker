﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PLPointTrackingSystem.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PLPointTrackingSystem.Services
{
    public class PowerliftDBContext : IdentityDbContext
    {
        public PowerliftDBContext(DbContextOptions options) : base (options)
        {

        }

        public DbSet<AthletesDAL> Athletes { get; set; }
    }
}

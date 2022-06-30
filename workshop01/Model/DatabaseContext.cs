using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using workshop01.Helper;
using workshop01.Model;

class AppDatabase : DbContext
{


    public DbSet<AmphurModel> AmphurModel => Set<AmphurModel>();


    //public DbSet<AlarmSpeed> AlarmSpeed => Set<AlarmSpeed>();





    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(ConfigHelper.ConnectionString);
}
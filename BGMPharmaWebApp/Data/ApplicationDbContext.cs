﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BGMPharmaWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BGMPharmaWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        #endregion

        #region Properties

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineType> MedicineTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        #endregion

        #region Override Methods

        //public override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Medicine>()
        //        .HasRequired()
        //}

        #endregion
    }
}

using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


using System.Text;

namespace Context
{
    public class Contex : DbContext, IContextDb
    {
        public Contex(DbContextOptions<Contex> options) : base(options)
        {
        }

        public DbSet<Casa> Casa { get; set; }
        public DbSet<Comprador> Comprador { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Casa>().ToTable("Casa");
            modelBuilder.Entity<Comprador>().ToTable("Comprador");
        }
    }
}

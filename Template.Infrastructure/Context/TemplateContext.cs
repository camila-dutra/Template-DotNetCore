using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Template.Domain.Entities;
using Template.Infrastructure.Extensions;
using Template.Infrastructure.Mappings;

namespace Template.Infrastructure.Context
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> option) : base(option)
        {
            //Database.EnsureCreated();
        }

        #region DbSets
        public DbSet<User> User { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());  //user configuration

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}

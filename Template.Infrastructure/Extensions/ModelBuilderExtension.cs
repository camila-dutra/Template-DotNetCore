using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Template.Domain.Entities;

namespace Template.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData( new User{ Id = Guid.Parse("42e5f94c-6c88-472c-bfd5-00e79e0aa640"), Name = "Joao da Silva", Email = "joao@template.com"});
            return builder;
        }
    }
}

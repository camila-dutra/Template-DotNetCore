using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Template.Domain.Entities;
using Template.Domain.Models;

namespace Template.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey();
                            break;
                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.DateCreated):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;


                    }
                    
                }
            }

            return builder;
        }
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData( new User{ Id = Guid.Parse("42e5f94c-6c88-472c-bfd5-00e79e0aa640"), 
                                                        Name = "Joao da Silva", 
                                                        Email = "joao@template.com", 
                                                        DateCreated = new DateTime(2021,07,13),
                                                        DateUpdated = null,
                                                        IsDeleted = false,

            });
            return builder;
        }
    }
}

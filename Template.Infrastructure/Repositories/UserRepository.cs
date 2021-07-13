using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;
using Template.Infrastructure.Context;
using Template.Infrastructure.Interfaces;

namespace Template.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(TemplateContext context) : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
    }
}

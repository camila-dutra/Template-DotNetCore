using System;
using System.Collections.Generic;
using System.Text;
using Template.Domain.Entities;

namespace Template.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}

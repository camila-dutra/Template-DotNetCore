using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Template.Infrastructure.Interfaces;
using Template.Infrastructure.Repositories;
using Template.Service.Interfaces;
using Template.Service.Services;

namespace Template.Service.DependencyInjection
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }

    }
}

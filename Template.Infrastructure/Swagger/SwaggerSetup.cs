using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Template.Infrastructure.Swagger
{
    public static class SwaggerSetup
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            return services.AddSwaggerGen(opt =>
                                          {
                                              opt.SwaggerDoc("v1", new OpenApiInfo
                                                                   {
                                                                       Title = "Template .Net Core",
                                                                       Version = "v1",
                                                                       Description = "Dev.Net Core",
                                                                       Contact = new OpenApiContact
                                                                           {
                                                                               Name = "Camila Martins",
                                                                               Email = "cmartinsdutra@gmail.com",
                                                                           },

                                              });

                                              string xmlPath = Path.Combine("wwwroot", "api-Doc.xml");
                                              opt.IncludeXmlComments(xmlPath);
                                          });
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
                                                 {
                                                     c.RoutePrefix = "documentation";
                                                     c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
                                                 });
        }
    }
}

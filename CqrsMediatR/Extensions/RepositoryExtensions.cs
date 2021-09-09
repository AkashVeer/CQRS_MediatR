using CqrsMediatR.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CqrsMediatR.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ProductDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ProductConnectionString")));
            return service;
        }
    }
}

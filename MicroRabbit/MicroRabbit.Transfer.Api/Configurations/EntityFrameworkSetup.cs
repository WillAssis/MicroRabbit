using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Api.Configurations
{
    public static class EntityFrameworkSetup
    {
        public static void AddEntityFrameworkSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqlContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("TransferDbConnection")));
        }
    }
}

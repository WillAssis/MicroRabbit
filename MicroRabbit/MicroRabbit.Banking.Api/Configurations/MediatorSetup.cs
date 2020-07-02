using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Api.Configurations
{
    public static class MediatorSetup
    {
        public static void AddMediatorSettup(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
        }
    }
}

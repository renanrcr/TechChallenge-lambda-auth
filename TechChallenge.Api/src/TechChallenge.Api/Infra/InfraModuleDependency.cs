﻿using Microsoft.Extensions.DependencyInjection;
using TechChallenge.Api.Domain.Adapters;
using TechChallenge.Api.Infra.Context;
using TechChallenge.Api.Infra.Repositories;

namespace TechChallenge.Api.Infra
{
    public static class InfraModuleDependency
    {
        public static void AddInfraModule(this IServiceCollection services)
        {
            services.AddScoped<DataBaseContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IIdentificacaoPedidoRepository, IdentificacaoPedidoRepository>();
        }
    }
}
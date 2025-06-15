using Microsoft.Extensions.DependencyInjection;
using PersonalLibrary.Application.Services;
using PersonalLibrary.CrossCutting.Interfaces;
using PersonalLibrary.CrossCutting.Services;
using PersonalLibrary.Domain.Interface;
using PersonalLibrary.Domain.Interface.Repository;
using PersonalLibrary.Domain.Interface.Service;
using PersonalLibrary.Domain.Notificacoes;
using PersonalLibrary.Domain.Services;
using PersonalLibrary.EF.Context;
using PersonalLibrary.EF.Repositories;


namespace LibraryBook.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Context
            services.AddScoped<PersonalLibraryContext>();

            //Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IItemService, ItemService>();

            //Reposiotories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();


            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}

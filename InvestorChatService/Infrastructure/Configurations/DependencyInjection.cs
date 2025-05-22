using InvestorChatService.Infrastructure.Persistence.DbContexts;
using InvestorChatService.Infrastructure.Persistence.Repositories;
using InvestorChatService.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InvestorChatService.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChatContext>(options =>
            {
                options.UseMySql(configuration.GetConnectionString("Default"), ServerVersion.AutoDetect(configuration.GetConnectionString("Default")));
            });

            return services;
        }
    }
}

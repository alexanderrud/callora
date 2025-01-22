using CalloraBot.Services;

namespace CalloraBot.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddTransient<MethodBuilder>()
                .AddTransient<HttpClient>();

            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using QRAdmit_Infrastructure.DatabaseContext;
using QRAdmit_Service.Implementations;
using QRAdmit_Service.Interfaces;

namespace QRAdmit_Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyOrigin()
                .AllowAnyMethod());
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QRAdmitContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection"))
                );
        }
    }

   
}

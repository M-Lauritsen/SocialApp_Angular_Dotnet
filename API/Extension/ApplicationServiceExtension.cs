using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings")); //Cloudinary Settings
            services.AddScoped<ITokenService, TokenService>(); // Token Service
            services.AddScoped<IPhotoService, PhotoService>(); // Photo Service
            services.AddScoped<IUserRepository, UserRepository>(); // User Repo
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly); // AutoMapper
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection")); // Sqlite Configuration
            });

            return services;
        }
    }
}
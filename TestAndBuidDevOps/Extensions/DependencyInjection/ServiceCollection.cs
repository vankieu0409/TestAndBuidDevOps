using System.Reflection;
using System.Text;

using Domain.Entities;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

using TestAndBuidDevOps.Data;
using TestAndBuidDevOps.Repositories.CartRepositories;
using TestAndBuidDevOps.Repositories.CategoryRepositories;
using TestAndBuidDevOps.Repositories.ImageRepositories;
using TestAndBuidDevOps.Repositories.OrderRepositories;
using TestAndBuidDevOps.Repositories.ProductRepositories;
using TestAndBuidDevOps.Repositories.RefreshTokenRepositories;
using TestAndBuidDevOps.Repositories.RoleRepositories;
using TestAndBuidDevOps.Repositories.UserRepositories;
using TestAndBuidDevOps.Services.Authentications;
using TestAndBuidDevOps.Services.CartService;
using TestAndBuidDevOps.Services.CategoryService;
using TestAndBuidDevOps.Services.OrderService;
using TestAndBuidDevOps.Services.ProductService;


namespace TestAndBuidDevOps.Extensions.DependencyInjection;

public static class ServiceCollection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, ConfigurationManager configuration)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        var entryAssembly = Assembly.GetEntryAssembly();
        services.AddCors();
        services.AddAutoMapper(configuration => { }, executingAssembly,
            entryAssembly);

        services.AddIdentity<UserEntity, RoleEntity>(options =>
        {
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
        }).AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();


        services.AddAuthentication(
                options => //được sử dụng để cấu hình xác thực trong ứng dụng và thiết lập chế độ xác thực và thách thức mặc định cho JWT bearer authentication.
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }
            ).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["Authentication:Jwt:ValidAudience"],
                    ValidIssuer = configuration["Authentication:Jwt:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:Jwt:Secret"]))
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n OnAuthenticationFailed: " + context.Exception.Message + '\n');
                        Console.ResetColor();
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n OnTokenValidated: " + context.SecurityToken + '\n');
                        Console.ResetColor();
                        return Task.CompletedTask;
                    },

                    OnForbidden = context =>
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n OnForbidden: " + context.Result + '\n');
                        Console.ResetColor();
                        Console.WriteLine();
                        return Task.CompletedTask;

                    },

                    OnChallenge = context =>
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\n OnChallenge: " + context.AuthenticateFailure + '\n');
                        Console.ResetColor();
                        return Task.CompletedTask;
                    },
                    OnMessageReceived = context =>
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n OnMessageReceived: " + context.Request.Headers.Authorization + '\n');
                        Console.ResetColor();
                        return Task.CompletedTask;
                    }
                };
            });

        services.AddAuthorization(option =>
        {
            option.FallbackPolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
        });
        //services.AddAuthorization(opt => opt.AddPolicy("test", o => o.RequireUserName("vankieu0409@gmail.com")));
        //    .AddGoogle(options =>
        //{
        //    options.ClientId = configuration["Authentication:Google:ClientId"];
        //    options.ClientSecret = configuration["Authentication:Google:ClientSecret"];
        //    options.CallbackPath = "/signin-google";
        //}).AddFacebook(options =>
        //    {
        //        options.ClientId = configuration["Authentication:Facebook:ClientId"];
        //        options.ClientSecret = configuration["Authentication:Facebook:ClientSecret"];
        //        options.CallbackPath = "/signin-facebook";
        //    });

        services.AddDbContext<ApplicationDbContext>(c => c.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")));
        //services.AddDbContext<ApplicationDbContext>(c => c.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")));
        services.AddHttpContextAccessor();
        // services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>)); //chỉ dùng cho class Gennerric
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IImageRepository, ImageRepository>();
        services.AddTransient<IRoleRepository, RoleRepository>();
        services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddTransient<ICartRepository, CartRepository>();
        services.AddTransient<IOrdersRepository, OrdersRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<UserManager<UserEntity>>();
        services.AddTransient<RoleManager<RoleEntity>>();
        services.AddTransient<SignInManager<UserEntity>>();

        services.AddTransient<IAuthenticationService, AuthenticationService>();
        services.AddTransient<ICartService, CartService>();
        services.AddTransient<ICategoryService, CategoryService>();
        services.AddTransient<IOrderService, OrderService>();
        services.AddTransient<IProductService, ProductService>();

        return services;

    }
}
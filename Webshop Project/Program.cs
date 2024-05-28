using Microsoft.EntityFrameworkCore;
using Webshop_Project.API.Business.Services;
using Webshop_Project.API.Data;
using Webshop_Project.API.Data.Entities;
using Webshop_Project.API.Data.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        InjectServices(builder);
        InjectDatabase(builder);
        InjectAutoMapper(builder);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }

    private static void InjectDatabase(WebApplicationBuilder builder)
    {
        string ConnectionString = builder.Configuration.GetConnectionString("WebshopConnectionString");
        builder.Services.AddDbContext<WebshopDBContext>(options => options.UseSqlServer(ConnectionString));
    }

    private static void InjectServices(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IBasketRepository,  BasketRepository>();
        builder.Services.AddScoped<IGenericRepo<BrandEntity>,  GenericRepo<BrandEntity>>();
        builder.Services.AddScoped<IGenericRepo<CategoryEntity>,  GenericRepo<CategoryEntity>>();
        builder.Services.AddScoped<IOrderRepository, OrderRepository>();
        builder.Services.AddScoped<ISmartphoneService, SmartphoneService>();
        builder.Services.AddScoped<ICategoryService, CategoryService>();
        builder.Services.AddScoped<IBrandService, BrandService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IBasketService, BasketService>();
        builder.Services.AddScoped<IGenericRepo<SmartphoneEntity>, GenericRepo<SmartphoneEntity>>();
        builder.Services.AddScoped<IGenericRepo<UserEntity>, GenericRepo<UserEntity>>();
        builder.Services.AddScoped<IGenericRepo<BasketEntity>, GenericRepo<BasketEntity>>();
    }

    private static void InjectAutoMapper(WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
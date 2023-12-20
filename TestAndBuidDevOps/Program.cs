using Domain.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi.Models;

using TestAndBuidDevOps.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews().AddOData(opt =>
{
    opt.Count().Filter().Expand().Select().OrderBy().SetMaxTop(5000).AddRouteComponents("odata", GetEdmModel());
    opt.TimeZone = TimeZoneInfo.Utc;
});
builder.Services.AddApplication(builder.Configuration);
builder.Services.AddHealthChecks();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
}); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API v1"));

}

app.UseCors(crosOption =>
{
    crosOption.AllowAnyHeader();
    crosOption.AllowAnyMethod();
    crosOption.AllowAnyOrigin();
});
app.UseHttpsRedirection();
app.UseRouting();
app.UseHealthChecks("/health");
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
IEdmModel GetEdmModel()
{
    var odataBuilder = new ODataConventionModelBuilder();

    odataBuilder.EntityType<UserDto>().HasKey(entity => new { entity.Id });
    odataBuilder.EntitySet<UserDto>("Identity");

    odataBuilder.EntityType<ProductEntity>().HasKey(entity => new { entity.Id });
    odataBuilder.EntitySet<ProductEntity>("Product");

    odataBuilder.EntityType<CartItemEntity>().HasKey(entity => new { entity.ProductId });
    odataBuilder.EntitySet<CartItemEntity>("CartItemEntity");


    odataBuilder.EntityType<CategoryEntity>().HasKey(entity => new { entity.Id });
    odataBuilder.EntitySet<CategoryEntity>("Category");

    odataBuilder.EntityType<OrderOverviewDto>().HasKey(entity => new { entity.Id });
    odataBuilder.EntitySet<OrderOverviewDto>("OrderOverviewDto");

    return odataBuilder.GetEdmModel();
}
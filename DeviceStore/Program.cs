using Microsoft.EntityFrameworkCore;
using DeviceStore.Data;
using Microsoft.AspNetCore.Identity;
using DeviceStore.Models;
using DeviceStore.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MobileContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<MobileContext>().AddDefaultTokenProviders();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthorization();
//builder.Services.AddSwaggerGen(c =>
//{
  //  c.SwaggerDoc("{6.2.3}", new OpenApiInfo { Title = "{DeviceStore}", Version = "{6.2.3}" });
//});
// Add a custom scoped service.
builder.Services.AddTransient<IAccountRepository, AccountRepository>();
//builder.Services.AddTransient<IMobileRepository, MobileRepository>();

var app = builder.Build();

// Add the memory cache services.



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();

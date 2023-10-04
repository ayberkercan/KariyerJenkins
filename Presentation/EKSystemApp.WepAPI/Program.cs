using EKSystemApp.Application;
using EKSystemApp.Domain.Entities;
using EKSystemApp.Persistence;
using EKSystemApp.Persistence.Context;
using EKSystemApp.Persistence.DbInitializerService;
using EKSystemApp.Persistence.DbInitiliazers;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
string MyAllowOrigins = "_myAllowOrigins";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo
    {
        Version = "V1",
        Title = "TURKUVAZ",
        Description = "KARÝYER WEB API"
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "TOKEN",
        Description = "Lütfen baþýnda BEARER yazmadan sadece tokený yazýnýz!",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List < string > ()
        }
    });
});

#region Service Registration
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
#endregion

#region NewtonsoftJson
builder.Services.AddControllersWithViews()
        .AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy(
        name: MyAllowOrigins,
        builder => {
            builder
                .WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/V1/swagger.json", "KARÝYER WEB API");
    });
}
#region DbInitiliazer

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
        var dbInitializer = services.GetRequiredService<IDbInitiliazerContext>();
        dbInitializer
            .Initialize(context, builder.Configuration).Wait();
        await DBPermissionsSeed.Seed(roleManager);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Database de bir sorun meydana geldi!");
    }
}
#endregion 
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseCors(MyAllowOrigins);

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

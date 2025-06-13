using Application.Services;
using Domain.Interfaces;
using finalProject.Repositories;
using Infrastructure.Extensions;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;   

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureJWT(configuration);
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddHttpClient<ChatPDFService>(client =>
{
    client.Timeout = TimeSpan.FromMinutes(5);
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCors",
            builder => builder.WithOrigins("http://localhost:4200", "https://guido-three.vercel.app") 
                              .AllowAnyMethod()
    .WithHeaders("Authorization", "Content-Type"));
});
builder.Services.AddControllersWithViews();
builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = 443;
});


var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors("MyCors");
app.MapControllers();
app.Run();

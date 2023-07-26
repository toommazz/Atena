using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using Atena.Domain.Core.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;
using Atena.Service.Mappings;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

string issuer = builder.Configuration.GetValue<string>("Jwt:Issuer");
string audience = builder.Configuration.GetValue<string>("Jwt:Audience");
string key = builder.Configuration.GetValue<string>("Jwt:Key");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = issuer,
            ValidAudience = audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
        };
    });

//Register DbContext
var cs = builder.Configuration.GetConnectionString("Atena");

builder.Services.AddDbContext<AtenaDataContext>(options =>
    options.UseSqlServer(cs))
    .AddScoped<DbContext, AtenaDataContext>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IMediatorHandler, InMemoryBus>();
builder.Services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
builder.Services.AddScoped<IEventStoreRepository, EventStoreRepository>();

builder.Services.Scan(i => i.FromApplicationDependencies(j => j.FullName.ToUpper().StartsWith("ATENA"))
    .AddClasses().AsMatchingInterface((service, filter) =>
        filter.Where(x => x.Name.Equals($"I{service.Name}", StringComparison.OrdinalIgnoreCase))).WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IMediator))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IRequestHandler<,>))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IRequestHandler<>))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(INotificationHandler<>))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IRequest<>))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IRepository<>))).AsImplementedInterfaces().WithScopedLifetime()
    .AddClasses(x => x.AssignableTo(typeof(IUnitOfWork))).AsImplementedInterfaces().WithScopedLifetime());

builder.Services.AddTransient(t => t.GetService<IHttpContextAccessor>().HttpContext.User);

builder.Services.AddSingleton(MappingsPeopleConfig.RegisterMappings().CreateMapper());
builder.Services.AddSingleton(MappingsPeopleConfig.RegisterMappings().CreateMapper());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using Museum;
using Museum.Data;
using Museum.Repository;
using Museum.Repository.IRepository;


var builder = WebApplication.CreateBuilder(args);


//Conexion a BD
builder.Services.AddDbContext<MuseumContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers().AddNewtonsoftJson();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<IAutorRepository, AutorRepository>();

builder.Services.AddScoped<IClientRepository, ClientRepository>();

builder.Services.AddScoped<IExposicionRepository, ExposicionRepository>();

builder.Services.AddScoped<IObraRepository, ObraRepository>();

builder.Services.AddScoped<ITicketRepository, TicketRepository>();



builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

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

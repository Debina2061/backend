using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Wandermate_backend.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options=>{
    options.AddPolicy("AllowAll",builder=>{
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(Options =>
Options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();



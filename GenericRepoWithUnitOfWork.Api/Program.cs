using GenericRepoWithUnitOfWork.Domain.RepositoryInterfaces;
using GenericRepoWithUnitOfWork.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using GenericRepoWithUnitOfWork.Infra.DBContext;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EcommerceContext>(options => { options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddMvc().AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

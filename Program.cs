using ErpAPI.Models;
using ErpAPI.Repositories;
using ErpAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ErpContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register your repositories
builder.Services.AddScoped<IRepository<Banco>, BancoRepository>();
builder.Services.AddScoped<IRepository<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IRepository<ClienteXempresa>, ClienteXempresaRepository>();
builder.Services.AddScoped<IRepository<Conta>, ContaRepository>();
builder.Services.AddScoped<IRepository<Empresa>, EmpresaRepository>();
builder.Services.AddScoped<IRepository<Funcionario>, FuncionarioRepository>();
builder.Services.AddScoped<IRepository<FuncionarioXprojeto>, FuncionarioXprojetoRepository>();
builder.Services.AddScoped<IRepository<Moeda>, MoedaRepository>();
builder.Services.AddScoped<IRepository<Pais>, PaisRepository>();
builder.Services.AddScoped<IRepository<Projeto>, ProjetoRepository>();

//Register your services
builder.Services.AddScoped<IEmpresaService, EmpresaService>();

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



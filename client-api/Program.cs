using Client_Infrastrutura.Dal.Interface;
using Client_Infrastrutura.Dal.Operacao;
using Client_servico.Interface;
using Client_servico.Servico;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IClientServico, ClientServico>();
builder.Services.AddScoped<IClientDAL, ClientDal>();
builder.Services.AddScoped<IClientDAL, ClientDal>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();

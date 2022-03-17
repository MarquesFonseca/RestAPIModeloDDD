using Microsoft.EntityFrameworkCore;
using RestAPIModeloDDD.Infrastructure.Data;

using RestAPIModeloDDD.Application.Implementation;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Application.Mapper;
using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;
using RestAPIModeloDDD.Domain.Services;
using RestAPIModeloDDD.Infrastructure.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//UseServiceProviderFactory(new AutofacServiceProviderFactory());

var connectionString = builder.Configuration["SqlConnection:SqlConnectionString"];
builder.Services.AddDbContext<Infrastructure_Data_SqlServerContext>(options => options.UseSqlServer(connectionString));

//ConfigureContainer(ContainerBuilder builder){
//    builder.reg
//}
//{

//}

//ContainerBuilder(ContainerBuilder.Build())

//builder.Services.AddTransient<Infrastructure_CrossCutting_IOC_ModuleIOC>();


#region IOC (Injeções de Dependências)

#region Cliente
builder.Services.AddScoped<Application_Interfaces_IApplicationServiceCliente, Application_Implementation_ApplicationServiceCliente>();
builder.Services.AddScoped<Domain_Core_Interfaces_Services_IServiceCliente, Domain_Services_ServiceCliente>();
builder.Services.AddScoped<Domain_Core_Interfaces_Repository_IRepositoryCliente,Infrastructure_Data_Repository_RepositoryCliente>();
builder.Services.AddScoped<Application_Interfaces_Mappers_IMapperCliente,Application_Mapper_MapperCliente>();
#endregion Cliente

#region Produto
builder.Services.AddScoped<Application_Interfaces_IApplicationServiceProduto, Application_Implementation_ApplicationServiceProduto>();
builder.Services.AddScoped<Domain_Core_Interfaces_Services_IServiceProduto, Domain_Services_ServiceProduto>();
builder.Services.AddScoped<Domain_Core_Interfaces_Repository_IRepositoryProduto, Infrastructure_Data_Repository_RepositoryProduto>();
builder.Services.AddScoped<Application_Interfaces_Mappers_IMapperProduto, Application_Mapper_MapperProduto>();
#endregion Produto

#endregion IOC (Injeções de Dependências)

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
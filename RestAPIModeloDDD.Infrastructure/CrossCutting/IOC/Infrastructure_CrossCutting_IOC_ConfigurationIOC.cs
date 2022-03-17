using Autofac;
using RestAPIModeloDDD.Application.Implementation;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Application.Mapper;
using RestAPIModeloDDD.Domain.Core.Interfaces.Repository;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;
using RestAPIModeloDDD.Domain.Services;
using RestAPIModeloDDD.Infrastructure.Data.Repository;

namespace RestAPIModeloDDD.Infrastructure.CrossCutting.IOC
{
    public static class Infrastructure_CrossCutting_IOC_ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC (Injeções de Dependências)

            #region Cliente
            builder.RegisterType<Application_Implementation_ApplicationServiceCliente>().As<Application_Interfaces_IApplicationServiceCliente>();
            builder.RegisterType<Domain_Services_ServiceCliente>().As<Domain_Core_Interfaces_Services_IServiceCliente>();
            builder.RegisterType<Infrastructure_Data_Repository_RepositoryCliente>().As<Domain_Core_Interfaces_Repository_IRepositoryCliente>();
            builder.RegisterType<Application_Mapper_MapperCliente>().As<Application_Interfaces_Mappers_IMapperCliente>();
            #endregion Cliente

            #region Produto
            builder.RegisterType<Application_Implementation_ApplicationServiceProduto>().As<Application_Interfaces_IApplicationServiceProduto>();
            builder.RegisterType<Domain_Services_ServiceProduto>().As<Domain_Core_Interfaces_Services_IServiceProduto>();
            builder.RegisterType<Infrastructure_Data_Repository_RepositoryProduto>().As<Domain_Core_Interfaces_Repository_IRepositoryProduto>();
            builder.RegisterType<Application_Mapper_MapperProduto>().As<Application_Interfaces_Mappers_IMapperProduto>();
            #endregion Produto

            #endregion IOC (Injeções de Dependências)
        }
    }
}
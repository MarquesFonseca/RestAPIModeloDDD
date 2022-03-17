using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;

namespace RestAPIModeloDDD.Application.Implementation
{
    public class Application_Implementation_ApplicationServiceCliente : Application_Interfaces_IApplicationServiceCliente
    {
        private readonly Domain_Core_Interfaces_Services_IServiceCliente serviceCliente;
        private readonly Application_Interfaces_Mappers_IMapperCliente mapperCliente;

        public Application_Implementation_ApplicationServiceCliente(Domain_Core_Interfaces_Services_IServiceCliente serviceCliente, Application_Interfaces_Mappers_IMapperCliente mapperCliente)
        {
            this.serviceCliente = serviceCliente ?? throw new ArgumentNullException(nameof(serviceCliente));
            this.mapperCliente = mapperCliente ?? throw new ArgumentNullException(nameof(mapperCliente));
        }

        public IEnumerable<Application_Dtos_ClienteDto> GetAll()
        {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClienteToListClienteDto(clientes);
        }

        public Application_Dtos_ClienteDto GetById(int id)
        {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperClienteToClienteDto(cliente);
        }

        public void Add(Application_Dtos_ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperClienteDtoToCliente(clienteDto);
            serviceCliente.Add(cliente);
        }

        public void Update(Application_Dtos_ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperClienteDtoToCliente(clienteDto);
            serviceCliente.Update(cliente);
        }

        public void Remove(Application_Dtos_ClienteDto clienteDto)
        {
            var cliente = mapperCliente.MapperClienteDtoToCliente(clienteDto);
            serviceCliente.Remove(cliente);
        }
    }
}

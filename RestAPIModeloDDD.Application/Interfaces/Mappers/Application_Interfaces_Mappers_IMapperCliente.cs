using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Application.Interfaces.Mappers
{
    public interface Application_Interfaces_Mappers_IMapperCliente
    {
        Cliente MapperClienteDtoToCliente(Application_Dtos_ClienteDto clienteDto);

        Application_Dtos_ClienteDto MapperClienteToClienteDto(Cliente cliente);
        
        IEnumerable<Application_Dtos_ClienteDto> MapperListClienteToListClienteDto(IEnumerable<Cliente> clientesList);

        IEnumerable<Cliente> MapperListClienteDtoToListCliente(IEnumerable<Application_Dtos_ClienteDto> clienteDtoList);
    }
}
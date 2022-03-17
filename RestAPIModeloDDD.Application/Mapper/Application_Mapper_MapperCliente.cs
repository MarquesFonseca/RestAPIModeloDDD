using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Application.Mapper
{
    public class Application_Mapper_MapperCliente : Application_Interfaces_Mappers_IMapperCliente
    {
        public Cliente MapperClienteDtoToCliente(Application_Dtos_ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };
            return cliente;
        }

        public Application_Dtos_ClienteDto MapperClienteToClienteDto(Cliente cliente)
        {
            var clienteDto = new Application_Dtos_ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
            return clienteDto;
        }

        public IEnumerable<Cliente> MapperListClienteDtoToListCliente(IEnumerable<Application_Dtos_ClienteDto> clienteDtoList)
        {
            var clientes = clienteDtoList.Select(x => new Cliente
            {
                Id = x.Id,
                Nome = x.Nome,
                Sobrenome = x.Sobrenome,
                Email = x.Email
            });

            return clientes;
        }

        public IEnumerable<Application_Dtos_ClienteDto> MapperListClienteToListClienteDto(IEnumerable<Cliente> clientesList)
        {
            var dto = clientesList.Select(x => new Application_Dtos_ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Sobrenome = x.Sobrenome,
                Email = x.Email
            });

            return dto;
        }
    }
}
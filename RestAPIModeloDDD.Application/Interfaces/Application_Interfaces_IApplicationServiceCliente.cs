using RestAPIModeloDDD.Application.Dtos;

namespace RestAPIModeloDDD.Application.Interfaces
{
    public interface Application_Interfaces_IApplicationServiceCliente
    {
        IEnumerable<Application_Dtos_ClienteDto> GetAll();

        Application_Dtos_ClienteDto GetById(int id);

        void Add(Application_Dtos_ClienteDto clienteDto);

        void Update(Application_Dtos_ClienteDto clienteDto);

        void Remove(Application_Dtos_ClienteDto clienteDto);
    }
}
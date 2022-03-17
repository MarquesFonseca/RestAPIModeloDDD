using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Core.Interfaces.Services;

namespace RestAPIModeloDDD.Application.Implementation
{
    public class Application_Implementation_ApplicationServiceProduto : Application_Interfaces_IApplicationServiceProduto
    {
        private readonly Domain_Core_Interfaces_Services_IServiceProduto serviceProduto;
        private readonly Application_Interfaces_Mappers_IMapperProduto mapperProduto;

        public Application_Implementation_ApplicationServiceProduto(Domain_Core_Interfaces_Services_IServiceProduto serviceProduto, Application_Interfaces_Mappers_IMapperProduto mapperProduto)
        {
            this.serviceProduto = serviceProduto ?? throw new ArgumentNullException(nameof(serviceProduto));
            this.mapperProduto = mapperProduto ?? throw new ArgumentNullException(nameof(mapperProduto));
        }

        public IEnumerable<Application_Dtos_ProdutoDto> GetAll()
        {
            var produto = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutoToListProdutoDto(produto);
        }

        public Application_Dtos_ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperProdutoToProdutoDto(produto);
        }

        public void Add(Application_Dtos_ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperProdutoDtoToProduto(produtoDto);
            serviceProduto.Add(produto);
        }

        public void Update(Application_Dtos_ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperProdutoDtoToProduto(produtoDto);
            serviceProduto.Update(produto);
        }

        public void Remove(Application_Dtos_ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperProdutoDtoToProduto(produtoDto);
            serviceProduto.Remove(produto);
        }
    }
}

using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Application.Interfaces.Mappers
{
    public interface Application_Interfaces_Mappers_IMapperProduto
    {
        Produto MapperProdutoDtoToProduto(Application_Dtos_ProdutoDto produtoDto);

        Application_Dtos_ProdutoDto MapperProdutoToProdutoDto(Produto produto);

        IEnumerable<Application_Dtos_ProdutoDto> MapperListProdutoToListProdutoDto(IEnumerable<Produto> produtoList);

        IEnumerable<Produto> MapperListProdutoDtoToListProduto(IEnumerable<Application_Dtos_ProdutoDto> produtoDtoList);
    }
}
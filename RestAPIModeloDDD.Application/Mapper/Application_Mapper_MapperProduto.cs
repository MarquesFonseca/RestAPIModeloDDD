using RestAPIModeloDDD.Application.Dtos;
using RestAPIModeloDDD.Application.Interfaces.Mappers;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Application.Mapper
{
    public class Application_Mapper_MapperProduto : Application_Interfaces_Mappers_IMapperProduto
    {
        public Produto MapperProdutoDtoToProduto(Application_Dtos_ProdutoDto ProdutoDto)
        {
            var produto = new Produto()
            {
                Id = ProdutoDto.Id,
                Nome = ProdutoDto.Nome,
                Valor = ProdutoDto.Valor
            };
            return produto;
        }

        public Application_Dtos_ProdutoDto MapperProdutoToProdutoDto(Produto Produto)
        {
            var produtoDto = new Application_Dtos_ProdutoDto()
            {
                Id = Produto.Id,
                Nome = Produto.Nome,
                Valor = Produto.Valor
            };
            return produtoDto;
        }

        public IEnumerable<Application_Dtos_ProdutoDto> MapperListProdutoToListProdutoDto(IEnumerable<Produto> produtoList)
        {
            var listProdutoDto = produtoList.Select(x => new Application_Dtos_ProdutoDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Valor = x.Valor
            });

            return listProdutoDto;
        }

        public IEnumerable<Produto> MapperListProdutoDtoToListProduto(IEnumerable<Application_Dtos_ProdutoDto> produtoDtoList)
        {
            var listProdutos = produtoDtoList.Select(x => new Produto
            {
                Id = x.Id,
                Nome = x.Nome,
                Valor = x.Valor
            });

            return listProdutos;
        }
    }
}
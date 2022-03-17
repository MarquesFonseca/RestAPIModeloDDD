using RestAPIModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.Application.Interfaces
{
    public interface Application_Interfaces_IApplicationServiceProduto
    {
        IEnumerable<Application_Dtos_ProdutoDto> GetAll();

        Application_Dtos_ProdutoDto GetById(int id);

        void Add(Application_Dtos_ProdutoDto produtoDto);

        void Update(Application_Dtos_ProdutoDto produtoDto);

        void Remove(Application_Dtos_ProdutoDto produtoDto);
    }
}

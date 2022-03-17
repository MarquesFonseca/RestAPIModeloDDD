using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Dtos;

namespace RestAPIModeloDDD.API.Controllers
{
    [Route("produto")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly Application_Interfaces_IApplicationServiceProduto _IApplicationServiceProduto;

        public ProdutosController(Application_Interfaces_IApplicationServiceProduto iApplicationServiceProduto)
        {
            _IApplicationServiceProduto = iApplicationServiceProduto ?? throw new ArgumentNullException(nameof(iApplicationServiceProduto));
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_IApplicationServiceProduto.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_IApplicationServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Application_Dtos_ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();


                _IApplicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Application_Dtos_ProdutoDto produtoDTO)
        {

            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _IApplicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] Application_Dtos_ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _IApplicationServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

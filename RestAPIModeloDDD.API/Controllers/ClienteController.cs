using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIModeloDDD.Application.Interfaces;
using RestAPIModeloDDD.Application.Dtos;

namespace RestAPIModeloDDD.API.Controllers
{
    [Route("cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Application_Interfaces_IApplicationServiceCliente _IApplicationServiceCliente;

        public ClienteController(Application_Interfaces_IApplicationServiceCliente iApplicationServiceCliente)
        {
            _IApplicationServiceCliente = iApplicationServiceCliente ?? throw new ArgumentNullException(nameof(iApplicationServiceCliente));
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_IApplicationServiceCliente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_IApplicationServiceCliente.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Application_Dtos_ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _IApplicationServiceCliente.Add(clienteDTO);
                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Application_Dtos_ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _IApplicationServiceCliente.Update(clienteDTO);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] Application_Dtos_ClienteDto clienteDTO)
        {
            try
            {
                if (clienteDTO == null)
                    return NotFound();

                _IApplicationServiceCliente.Remove(clienteDTO);
                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

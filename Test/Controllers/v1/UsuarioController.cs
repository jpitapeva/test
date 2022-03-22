using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test.v1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        //TODO
        //Implementar camada de servico
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Este endpoint deve consultar as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna a lista com todas as interessadas cadastradas
        /// </returns>
        [HttpGet]
        public IActionResult ConsultarTodos()
        {
            return Ok();
        }

        /// <summary>
        /// Este endpoint deve consultar o cadastro através do nome e e-mail
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpGet]
        [Route("consultar/{nome}/{email}")]
        public IActionResult ConsultarPorEmail(string nome, string email)
        {
            return Ok();
        }

        /// <summary>
        ///  Este endpoint deve realizar a inclusao
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPost]
        [Route("incluir")]
        public IActionResult Adicionar()
        {
            return Ok();
        }

        /// <summary>
        /// Este endpoint deve atualizar os dados cadastrados
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPut]
        [Route("atualizar")]
        public IActionResult Atualizar()
        {
            return Ok();
        }

        /// <summary>
        /// Este endpoint deve excluir um cadastro através do e-mail informado
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpDelete]
        [Route("excluir/{email}")]
        public IActionResult Excluir(string email)
        {
            return Ok();
        }
    }
}

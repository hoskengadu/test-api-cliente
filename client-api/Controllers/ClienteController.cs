using Client_Domain.DTO;
using Client_servico.Interface;
using Microsoft.AspNetCore.Mvc;

namespace client_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClientServico _clientServico;
        public ClienteController(ILogger<ClienteController> log, IClientServico clientServico)
        {
            _logger = log;
            _clientServico = clientServico; 
        }

        [HttpGet("/cliente")]
        public async Task<IActionResult> getClient()
        {
            return null;
        }

        [HttpPost("/cadastro_cliente")]
        public async Task<IActionResult>postCliente([FromBody] ClientEntrada entrada)
        {
            try
            {
               var cliente =  _clientServico.postClient(entrada);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao cadastrar cliente. Motivo:{ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

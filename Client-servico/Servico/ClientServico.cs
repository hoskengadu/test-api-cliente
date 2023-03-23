using Client_Domain.DTO;
using Client_Infrastrutura.Dal.Interface;
using Client_servico.Interface;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_servico.Servico
{
    public class ClientServico : IClientServico
    {
        private readonly ILogger<ClientServico> _logger;
        private readonly IClientDAL _clientDAL;
        public ClientServico(ILogger<ClientServico> log, IClientDAL clientDAL)
        {
            _logger = log;
            _clientDAL = clientDAL;
        }

        public async Task postClient(ClientEntrada entrada)
        {
            await _clientDAL.postCliente(entrada);
        }
    }
}

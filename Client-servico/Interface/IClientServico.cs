using Client_Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_servico.Interface
{
    public interface IClientServico
    {
       public Task postClient(ClientEntrada entrada);
    }
}

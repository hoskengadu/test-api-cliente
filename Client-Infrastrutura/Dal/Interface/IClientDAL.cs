using Client_Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Infrastrutura.Dal.Interface
{
    public interface IClientDAL
    {
       public Task postCliente(ClientEntrada entrada);
    }
}

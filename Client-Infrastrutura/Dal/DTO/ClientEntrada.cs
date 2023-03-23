using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Domain.DTO
{
    public class ClientEntrada
    {
        public string nome { get; set; }    
        public string sobrenome { get; set; }   
        public long numero_contato { get; set; }    
        public string email { get; set; }   
        public long cpf { get; set; }   
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }    
        public string endereco { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }

    }
}

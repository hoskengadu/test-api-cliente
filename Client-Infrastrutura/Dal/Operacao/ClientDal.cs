using Client_Domain.DTO;
using Client_Infrastrutura.Dal.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Infrastrutura.Dal.Operacao
{
    public class ClientDal : IClientDAL
    {
        private readonly IConfiguration configuration;
        public ClientDal(IConfiguration config)
        {
            configuration = config;
        }
        public async Task postCliente(ClientEntrada entrada)
        {
            try
            {
                var query = $"Insert Into Cliente(nome, sobrenome, numero_contato, email, cpf, data_nascimento, sexo, endereco, estado, cidade) values({entrada.nome}, {entrada.sobrenome}, {entrada.numero_contato},{entrada.email}, {entrada.cpf}, {entrada.data_nascimento.Date}, {entrada.sexo}, {entrada.endereco}, {entrada.estado}, {entrada.cidade})";

                SqlConnection sqlConnection1 = new SqlConnection(configuration["conectString"]);
                SqlCommand cmd = new SqlCommand();
                SqlDataReader reader;

                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteReader();
                sqlConnection1.Close();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}

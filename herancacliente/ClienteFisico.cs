using System;
namespace herancacliente
{
    public class ClienteFisico : Cliente
    {
        public string cpf { get; set; }

        public ClienteFisico(string nome, Bairro bairro, string telefone, string cpf)
        {
            this.nome = nome;
            this.bairro = bairro;
            this.telefone = telefone;
            this.cpf = cpf;

        }
    }
}

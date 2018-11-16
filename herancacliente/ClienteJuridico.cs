using System;
namespace herancacliente
{
    public class ClienteJuridico : Cliente
    {
        public string cnpj { get; set; }

        public ClienteJuridico(string nome, Bairro bairro, string telefone, string cnpj)
        {
            this.nome = nome;
            this.bairro = bairro;
            this.telefone = telefone;
            this.cnpj = cnpj;

        }
        public ClienteJuridico()
        {
        }
    }
}

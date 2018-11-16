using System;
namespace herancacliente
{
    public class Cliente
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public Bairro bairro { get; set; }

        public Cliente()
        {
        }
    }
}